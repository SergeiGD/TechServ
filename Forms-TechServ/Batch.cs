using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Forms_TechServ
{
    public class Batch
    {
        public int Id { get; set; }
        public string TrackNumber { get; set; }
        public DateTime? DateDelivered { get; set; }

        //private decimal price;

        public decimal Price 
        {
            get;set;
            /*get 
            {
                return price;
            }
            private set
            {
                //price = CalcFinalPrice();
                using (TechContext db = new TechContext())
                {
                    price = value;
                    db.Entry(this).State = EntityState.Modified;
                    db.SaveChanges();
                }
            } */
        }

        [Column("Id_Workshop")]
        public int WorkshopId { get; set; }
        [Column("Id_Workshop")]
        public Workshop Workshop { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddBatch()
        {
            using (TechContext db = new TechContext())
            {
                db.Batches.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditBatch()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelBatch()
        {
            using (TechContext db = new TechContext())
            {
                this.DelTime = DateTime.Now;

                if (DateDelivered == null)                           // нельзя удалить уже прибывшую поставку
                {
                    
                    // УДАЛЯЕМ ДЕТАЛИ ИЗ ЗАКАЗОВ
                    db.OrdersSpareParts.RemoveRange(db.OrdersSpareParts.Where(s => s.BatchId == this.Id));

                    db.Entry(this).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<BatchSparePart> GetSpareParts(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<BatchSparePart> spareParts = db.BatchesSpareParts.Where(s => s.BatchId == this.Id).Include(s => s.SparePart);

                rowsCount = spareParts.Count();                                  // общее кол-во строк для постраничного вывода

                spareParts = spareParts.Skip((page - 1) * count).Take(count);

                return spareParts.ToList();
            }
        }

        public int GetCountLeft(SparePart sparePart)
        {
            using (TechContext db = new TechContext())
            {
                BatchSparePart batchSparePart = db.BatchesSpareParts.Where(s => s.BatchId == this.Id && s.SparePartId == sparePart.Id).FirstOrDefault();
                int quantity = batchSparePart.Quantity;

                foreach (SparePartFromBatch orderSparePart in db.OrdersSpareParts.Where(b => b.BatchId == this.Id && b.SparePartId == sparePart.Id))
                {
                    quantity -= orderSparePart.Quantity;
                }

                return quantity;//batchSparePart.Quantity; // минус OrderSparePart....
            }
        }

        public bool IsSpent()
        {
            using(TechContext db = new TechContext())
            {

                foreach (BatchSparePart sparePart in db.BatchesSpareParts.Where(b => b.BatchId == this.Id))
                {
                    int quantity = sparePart.Quantity;

                    foreach (SparePartFromBatch orderSparePart in db.OrdersSpareParts.Where(b => b.BatchId == this.Id && b.SparePartId == sparePart.SparePartId))
                    {
                        quantity -= orderSparePart.Quantity;
                    }

                    if(quantity > 0)
                    {
                        return false;
                    }
                }

                return true;

            }

        }

        public decimal CalcFinalPrice()
        {
            using (TechContext db = new TechContext())
            {
                decimal currentPrice = 0;
                foreach (BatchSparePart batchSparePart in db.BatchesSpareParts.Where(s => s.BatchId == this.Id))
                {
                    currentPrice += batchSparePart.Quantity * batchSparePart.UnitPrice;
                }

                //this.Price = currentPrice;
                //this.Price = currentPrice;
                //db.Entry(this).State = EntityState.Modified;
                //db.SaveChanges();


                return currentPrice;
            }

        }

        public int CalcSparePartsCount()
        {
            using (TechContext db = new TechContext())
            {
                return db.BatchesSpareParts.Where(b => b.BatchId == this.Id).Count();
            }
        }

        public bool AddSparePart(BatchSparePart sparePart)
        {
            using (TechContext db = new TechContext())
            {

                if(this.DateDelivered == null)
                {
                    sparePart.BatchId = this.Id;

                    db.BatchesSpareParts.Add(sparePart);

                    db.SaveChanges();

                    //CalcFinalPrice();

                    Batch batchToUpdate = db.Batches.Find(this.Id);
                    this.Price = CalcFinalPrice();
                    db.Entry(batchToUpdate).CurrentValues.SetValues(this);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool DelSparePart(BatchSparePart sparePart)
        {
            using (TechContext db = new TechContext())
            {
                if(this.DateDelivered == null)
                {
                    db.OrdersSpareParts.RemoveRange(db.OrdersSpareParts.Where(s => s.BatchId == this.Id && s.SparePartId == sparePart.SparePartId));

                    db.Entry(sparePart).State = EntityState.Deleted;

                    db.SaveChanges();

                    Batch batchToUpdate = db.Batches.Find(this.Id);
                    this.Price = CalcFinalPrice();
                    db.Entry(batchToUpdate).CurrentValues.SetValues(this);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
                // нельзя изменять уже прибывшую поставку

            }
        }

        public bool EditSparePart(BatchSparePart sparePart)
        {
            using (TechContext db = new TechContext())
            {
                if (this.DateDelivered == null)
                {
                    db.Entry(sparePart).State = EntityState.Modified;

                    db.SaveChanges();

                    Batch batchToUpdate = db.Batches.Find(this.Id);
                    this.Price = CalcFinalPrice();
                    db.Entry(batchToUpdate).CurrentValues.SetValues(this);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public BatchSparePart GetSparePart(int id)
        {
            using (TechContext db = new TechContext())
            {
                return db.BatchesSpareParts.Find(this.Id, id);
            }
        }
        
        public bool CheckSparePart(SparePart sparePart)
        {
            using (TechContext db = new TechContext())
            {
                BatchSparePart batchSparePart = db.BatchesSpareParts.Find(this.Id, sparePart.Id);

                if (batchSparePart != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }

    public static class BatchesList
    {
        public static Batch GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                Batch batch = db.Batches.Find(id);
                db.Entry(batch).Reference(b => b.Workshop).Load();
                return batch;
            }
        }

        public static List<Batch> GetBatches(Batch FilterA, Batch FilterB, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Batch> batches = db.Batches.Where(b => b.DelTime == null).Include(b => b.Workshop);

                if (FilterA.Id != 0)
                {
                    batches = batches.Where(b => b.Id == FilterA.Id);
                }

                if (FilterA.TrackNumber != null && FilterA.TrackNumber != string.Empty)
                {
                    batches = batches.Where(b => b.TrackNumber.IndexOf(FilterA.TrackNumber, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.DateDelivered.HasValue && !FilterB.DateDelivered.HasValue)
                {
                    batches = batches.Where(b => b.DateDelivered >= FilterA.DateDelivered);
                }

                if (!FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                {
                    batches = batches.Where(b => b.DateDelivered <= FilterB.DateDelivered);
                }

                if (FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                {
                    batches = batches.Where(b => b.DateDelivered >= FilterA.DateDelivered && b.DateDelivered <= FilterB.DateDelivered);
                }

                if (FilterA.Price > 0 && FilterB.Price == 0)
                {
                    batches = batches.Where(b => b.Price >= FilterA.Price);
                }

                if (FilterA.Price == 0 && FilterB.Price > 0)
                {
                    batches = batches.Where(b => b.Price <= FilterB.Price);
                }

                if (FilterA.Price > 0 && FilterB.Price > 0)
                {
                    batches = batches.Where(b => b.Price >= FilterA.Price && b.Price <= FilterB.Price);
                }

                if(FilterA.Workshop != null)
                {
                    batches = batches.Where(b => b.WorkshopId == FilterA.Workshop.Id);
                }

                batches = batches.SortBy(sortBy, desk);

                rowsCount = batches.Count();                                  // общее кол-во строк для постраничного вывода

                batches = batches.Skip((page - 1) * count).Take(count);

                return batches.ToList();
            }
        }

        // ПОИСК ПОСТАВОК С ОПРЕДЕЛЕННОЙ ДЕТАЛЬЮ (ДЛЯ ЗАКАЗОВ)
        public static List<Batch> GetBatchesWithSparePart(Batch FilterA, Batch FilterB, SparePart sparePart, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Batch> batches = db.Batches.Where(b => b.DelTime == null).Include(b => b.Workshop);

                

                if (FilterA.Id != 0)
                {
                    batches = batches.Where(b => b.Id == FilterA.Id);
                }

                if (FilterA.TrackNumber != null && FilterA.TrackNumber != string.Empty)
                {
                    batches = batches.Where(b => b.TrackNumber.IndexOf(FilterA.TrackNumber, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.Workshop != null)
                {
                    batches = batches.Where(b => b.WorkshopId == FilterA.Workshop.Id);
                }



                



                if (FilterA.DateDelivered.HasValue && !FilterB.DateDelivered.HasValue)
                {
                    batches = batches.Where(b => b.DateDelivered >= FilterA.DateDelivered);
                }

                if (!FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                {
                    batches = batches.Where(b => b.DateDelivered <= FilterB.DateDelivered);
                }

                if (FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                {
                    batches = batches.Where(b => b.DateDelivered >= FilterA.DateDelivered && b.DateDelivered <= FilterB.DateDelivered);
                }

                if (FilterA.Price > 0 && FilterB.Price == 0)
                {
                    batches = batches.Where(b => b.Price >= FilterA.Price);
                }

                if (FilterA.Price == 0 && FilterB.Price > 0)
                {
                    batches = batches.Where(b => b.Price <= FilterB.Price);
                }

                if (FilterA.Price > 0 && FilterB.Price > 0)
                {
                    batches = batches.Where(b => b.Price >= FilterA.Price && b.Price <= FilterB.Price);
                }

                batches = batches.Where(b => b.CheckSparePart(sparePart));
                batches = batches.Where(b => b.GetCountLeft(sparePart) > 0);

                batches = batches.SortBy(sortBy, desk);

                rowsCount = batches.Count();                                  // общее кол-во строк для постраничного вывода

                batches = batches.Skip((page - 1) * count).Take(count);

                return batches.ToList();
            }
        }
    }

    [Table("BatchesSpareParts")]
    public class BatchSparePart
    {
        [Column("Id_Batch")]
        public int BatchId { get; set; }
        [Column("Id_Batch")]
        public Batch Batch { get; set; }

        [Column("Id_SparePart")]
        public int SparePartId { get; set; }
        [Column("Id_SparePart")]
        public SparePart SparePart { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        /*public bool AddBatchSparePart()
        {
            using (TechContext db = new TechContext())
            {
                //db.Entry(this).Reference(s => s.Batch).Load();

                db.BatchesSpareParts.Add(this);

                db.Entry(db.BatchesSpareParts.Find(this.BatchId, this.SparePartId)).Reference(s => s.Batch).Load();

                if (this.Batch.DateDelivered == null)
                {
                    // ЧЕРЕЗ GET BY ID
                    this.Batch.Price = Quantity * UnitPrice;
                    db.Entry(this.Batch).State = EntityState.Modified;

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }     
            }
        }

        public bool EditBatchSparePart()
        {
            using (TechContext db = new TechContext())
            {
                // нельзя изменять уже прибывшую поставку
                //db.Entry(db.BatchesSpareParts.(this.BatchId, this.SparePartId)).Reference(s => s.Batch).Load();
                db.Entry(BatchesSparePartsList.GetById(this.BatchId, this.SparePartId)).Reference(s => s.Batch).Load();
                if (this.Batch.DateDelivered == null)
                {
                    db.Entry(this).State = EntityState.Modified;

                    Batch.Price = Batch.CalcFinalPrice();

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DelBatchSparePart()
        {
            using (TechContext db = new TechContext())
            {
                // нельзя изменять уже прибывшую поставку
                //db.Entry(db.BatchesSpareParts.Find(this.BatchId, this.SparePartId)).Reference(s => s.Batch).Load();
                db.Entry(BatchesSparePartsList.GetById(this.BatchId, this.SparePartId)).Reference(s => s.Batch).Load();
                if (this.Batch.DateDelivered == null)
                {
                    db.Entry(this).State = EntityState.Deleted;

                    Batch.Price = Batch.CalcFinalPrice();

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }*/
    }

    /*public static class BatchesSparePartsList
    {
        public static BatchSparePart GetById(int idBatch, int idSparePart)
        {
            using (TechContext db = new TechContext())
            {
                BatchSparePart sparePart = db.BatchesSpareParts.Find(idBatch, idSparePart);
                if(sparePart != null)
                {
                    db.Entry(sparePart).Reference(b => b.Batch).Load();
                }
                
                return sparePart;
            }
        }
    }*/
}
