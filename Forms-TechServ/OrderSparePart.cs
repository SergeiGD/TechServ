using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
{

    public class OrderSparePart
    {

        //public int OrderId { get; set; }

        public Order Order { get; set; }


        //public int SparePartId { get; set; }
      
        public SparePart SparePart{ get; set; }

        

        public Dictionary<Batch, int> GetBatchesInfo()
        {
            using(TechContext db = new TechContext())
            {
                Dictionary<Batch, int> orderSpareParts = new Dictionary<Batch, int>();

                foreach(var item in db.OrdersSpareParts.Where(s => s.OrderId == this.Order.Id && s.SparePartId == this.SparePart.Id).Include(s => s.SparePart).Include(s => s.Batch))
                {
                    orderSpareParts.Add(item.Batch, item.Quantity);
                }

                return orderSpareParts;
            }
        }


        public bool AddBatchInfo(Batch batch, int quantity)
        {
            using (TechContext db = new TechContext())
            {

                if(batch.GetCountLeft(this.SparePart) < quantity)
                {
                    return false;
                }
                else
                {
                    SparePartFromBatch sparePartFromBatch = new SparePartFromBatch()
                    {
                        OrderId = this.Order.Id,
                        BatchId = batch.Id,
                        SparePartId = SparePart.Id,
                        Quantity = quantity
                    };


                    db.OrdersSpareParts.Add(sparePartFromBatch);

                    db.SaveChanges();

                    return true;
                }
                
            }
        }

        public bool DelBatchInfo(Batch batch)
        {
            using (TechContext db = new TechContext())
            {
                

                SparePartFromBatch sparePartFromBatch = db.OrdersSpareParts.Find(this.Order.Id, this.SparePart.Id, batch.Id);

                

                db.OrdersSpareParts.Remove(sparePartFromBatch);

                db.SaveChanges();

                return true;
            }
        }

        public bool EditQuantity(Batch batch, int quantity) 
        {
            using (TechContext db = new TechContext())
            {
                if(batch.GetCountLeft(this.SparePart) < quantity)
                {
                    return false;
                }
                else
                {
                    SparePartFromBatch sparePartFromBatch = db.OrdersSpareParts.Find(this.Order.Id, this.SparePart.Id, batch.Id);
                    sparePartFromBatch.Quantity = quantity;
                    db.SaveChanges();
                    return true;
                }
                
            }
        }

        public decimal CalcBatchPrice(Batch batch)
        {
            using (TechContext db = new TechContext())
            {
                SparePartFromBatch sparePartFromBatch = db.OrdersSpareParts.Find(this.Order.Id, this.SparePart.Id, batch.Id);
                return sparePartFromBatch.Quantity * batch.GetSparePart(this.SparePart.Id).UnitPrice;
            }
        }

        public decimal CalcPrice()
        {
            using (TechContext db = new TechContext())
            {
                decimal price = 0;
                foreach(KeyValuePair<Batch, int> batchInfo in GetBatchesInfo())
                {
                    price += batchInfo.Key.GetSparePart(this.SparePart.Id).UnitPrice * batchInfo.Value;
                }

                return price;
            }
        }

        public bool CheckBatchesDelivered()
        {
            //using (TechContext db = new TechContext())
            //{
                
                foreach(Batch batch in GetBatchesInfo().Keys)
                {
                    if (!batch.DateDelivered.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            //}
        }

        public int CalcSparePartsQuanity()
        {
            int count = 0;
            foreach (int inBatchCount in GetBatchesInfo().Values)
            {
                count += inBatchCount;
            }

            return count;
        }

        // ПРОВЕРКА ЕСТЬ ЛИ УЖЕ ТАКАЯ ПОСТАВКА
        public bool CheckBatch(Batch batch)
        {
            foreach(Batch batchInOrder in GetBatchesInfo().Keys)
            {
                if(batchInOrder.Id == batch.Id)
                {
                    return true;
                }
            }
            return false;

            
        }

        public bool DelSparePart()
        {
            using (TechContext db = new TechContext())
            {
                foreach(SparePartFromBatch sparePartFromBatch in db.OrdersSpareParts.Where(s => s.OrderId == this.Order.Id && s.SparePartId == SparePart.Id))
                {
                    db.OrdersSpareParts.Remove(sparePartFromBatch);
                    
                }
                db.SaveChanges();
                return true;
            }
                
        }

        public bool FindBatchesAuto(int quantity)
        {

            using (TechContext db = new TechContext())
            {

                using (var transaction = db.Database.BeginTransaction())
                {


                    foreach (Batch batch in db.Batches.Where(b => b.WorkshopId == Order.WorkshopId).ToList().Where(b => b.CheckSparePart(this.SparePart) && b.GetCountLeft(this.SparePart) > 0))//.OrderBy(b => b.DateDelivered))
                    {

                        if (batch.GetCountLeft(this.SparePart) >= quantity)
                        {
                            db.OrdersSpareParts.Add(new SparePartFromBatch()
                            {
                                OrderId = Order.Id,
                                BatchId = batch.Id,
                                SparePartId = SparePart.Id,
                                Quantity = quantity
                            });

                            quantity = 0;
                            db.SaveChanges();
                            break;
                        }

                        if (batch.GetCountLeft(this.SparePart) < quantity)
                        {
                            quantity -= batch.GetCountLeft(SparePart);

                            db.OrdersSpareParts.Add(new SparePartFromBatch()
                            {
                                OrderId = Order.Id,
                                BatchId = batch.Id,
                                SparePartId = SparePart.Id,
                                Quantity = batch.GetCountLeft(SparePart)
                            });


                            db.SaveChanges();

                        }
                    }

                    if (quantity == 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }

                }
                
            }
        }

    }
}

