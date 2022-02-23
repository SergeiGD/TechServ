using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.spareParts;
using Forms_TechServ.classes.workshops;

namespace Forms_TechServ.classes.batches
{
    public class Batch
    {
        public int Id { get; set; }
        public string TrackNumber { get; set; }
        public DateTime? DateDelivered { get; set; }

        public BatchStatus Status { get; set; }

        public decimal Price { get; set; }

        [Column("Id_Workshop")] public int WorkshopId { get; set; }

        [Column("Id_Workshop")] public Workshop Workshop { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddBatch()
        {
            using (var db = new TechContext())
            {
                db.Batches.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditBatch()
        {
            using (var db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelBatch(out List<string> ordersInUse)
        {
            ordersInUse = new List<string>();
            using (var db = new TechContext())
            {
                if (db.OrdersSpareParts.Any(s => s.BatchId == Id)) // нельзя удалить поставку, если ее детали уже используются
                {
                    foreach (var order in db.OrdersSpareParts.Where(s => s.BatchId == Id))
                        ordersInUse.Add("№" + order.OrderId);
                    return false;
                }

                DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelBatch()
        {
            using (var db = new TechContext())
            {
                if (db.OrdersSpareParts.Any(s => s.BatchId == Id)) // нельзя удалить поставку, если ее детали уже используются
                    return false;

                DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public List<BatchSparePart> GetSpareParts(int count, int page, out int rowsCount)
        {
            using (var db = new TechContext())
            {
                IEnumerable<BatchSparePart> spareParts = db.BatchesSpareParts.Where(s => s.BatchId == Id)
                    .Include(s => s.SparePart).Include(s => s.Batch);

                rowsCount = spareParts.Count(); // общее кол-во строк для постраничного вывода

                spareParts = spareParts.Skip((page - 1) * count).Take(count);

                return spareParts.ToList();
            }
        }

        public int GetCountLeft(SparePart sparePart)
        {
            using (var db = new TechContext())
            {
                var batchSparePart = db.BatchesSpareParts.Where(s => s.BatchId == Id && s.SparePartId == sparePart.Id)
                    .FirstOrDefault();
                var quantity = batchSparePart.Quantity;

                foreach (var orderSparePart in db.OrdersSpareParts.Where(b =>
                             b.BatchId == Id && b.SparePartId == sparePart.Id)) quantity -= orderSparePart.Quantity;

                return quantity;
            }
        }

        public bool IsSpent()
        {
            using (var db = new TechContext())
            {
                foreach (var sparePart in db.BatchesSpareParts.Where(b => b.BatchId == Id))
                {
                    var quantity = sparePart.Quantity;

                    foreach (var orderSparePart in db.OrdersSpareParts.Where(b =>
                                 b.BatchId == Id && b.SparePartId == sparePart.SparePartId))
                        quantity -= orderSparePart.Quantity;

                    if (quantity > 0) return false;
                }

                return true;
            }
        }

        public decimal CalcFinalPrice()
        {
            using (var db = new TechContext())
            {
                decimal currentPrice = 0;
                foreach (var batchSparePart in db.BatchesSpareParts.Where(s => s.BatchId == Id))
                    currentPrice += batchSparePart.Quantity * batchSparePart.UnitPrice;


                return currentPrice;
            }
        }

        public int CalcSparePartsCount()
        {
            using (var db = new TechContext())
            {
                return db.BatchesSpareParts.Where(b => b.BatchId == Id).Count();
            }
        }

        public bool AddSparePart(BatchSparePart sparePart)
        {
            using (var db = new TechContext())
            {
                if (Status != BatchStatus.Подтверждена && Status != BatchStatus.Прибыла)
                {
                    sparePart.BatchId = Id;

                    db.BatchesSpareParts.Add(sparePart);

                    db.SaveChanges();


                    var batchToUpdate = db.Batches.Find(Id);
                    Price = CalcFinalPrice();
                    db.Entry(batchToUpdate).CurrentValues.SetValues(this);
                    db.SaveChanges();

                    return true;
                }

                return false;
            }
        }

        public bool DelSparePart(BatchSparePart sparePart)
        {
            using (var db = new TechContext())
            {
                if (Status != BatchStatus.Подтверждена && Status != BatchStatus.Прибыла)
                {
                    db.Entry(sparePart).State = EntityState.Deleted;

                    db.SaveChanges();

                    var batchToUpdate = db.Batches.Find(Id);
                    Price = CalcFinalPrice();
                    db.Entry(batchToUpdate).CurrentValues.SetValues(this);
                    db.SaveChanges();

                    return true;
                }

                return false; // нельзя изменять уже прибывшую/подтвержденную поставку
            }
        }

        public bool EditSparePart(BatchSparePart sparePart)
        {
            using (var db = new TechContext())
            {
                if (Status != BatchStatus.Подтверждена && Status != BatchStatus.Прибыла)
                {
                    db.Entry(sparePart).State = EntityState.Modified;

                    db.SaveChanges();

                    var batchToUpdate = db.Batches.Find(Id);
                    Price = CalcFinalPrice();
                    db.Entry(batchToUpdate).CurrentValues.SetValues(this);
                    db.SaveChanges();

                    return true;
                }

                return false;
            }
        }

        public BatchSparePart GetSparePart(int id)
        {
            using (var db = new TechContext())
            {
                return db.BatchesSpareParts.Find(Id, id);
            }
        }

        public bool CheckSparePart(SparePart sparePart)
        {
            using (var db = new TechContext())
            {
                var batchSparePart = db.BatchesSpareParts.Find(Id, sparePart.Id);

                if (batchSparePart != null)
                    return true;
                return false;
            }
        }
    }
}