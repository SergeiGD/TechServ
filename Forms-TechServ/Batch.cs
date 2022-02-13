using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Forms_TechServ
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
                if (db.OrdersSpareParts.Where(s => s.BatchId == Id).Count() >
                    0) // нельзя удалить поставку, если ее детали уже используются
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
                if (db.OrdersSpareParts.Where(s => s.BatchId == Id).Count() >
                    0) // нельзя удалить поставку, если ее детали уже используются
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

    public enum BatchStatus
    {
        Создана,
        Подтверждена,
        Прибыла,
        Неопределенный
    }

    public static class BatchesList
    {
        public static Batch GetById(int id)
        {
            using (var db = new TechContext())
            {
                var batch = db.Batches.Find(id);
                db.Entry(batch).Reference(b => b.Workshop).Load();
                return batch;
            }
        }

        public static List<Batch> GetBatches(Batch FilterA, Batch FilterB, bool desk, string sortBy, int count,
            int page, out int rowsCount)
        {
            using (var db = new TechContext())
            {
                IEnumerable<Batch> batches = db.Batches.Where(b => b.DelTime == null).Include(b => b.Workshop);

                if (FilterA.Id != 0) batches = batches.Where(b => b.Id == FilterA.Id);

                if (FilterA.TrackNumber != null && FilterA.TrackNumber != string.Empty)
                    batches = batches.Where(b =>
                        b.TrackNumber.IndexOf(FilterA.TrackNumber, StringComparison.OrdinalIgnoreCase) > -1);

                if (FilterA.Status != BatchStatus.Неопределенный)
                    batches = batches.Where(b => b.Status == FilterA.Status);

                if (FilterA.DateDelivered.HasValue && !FilterB.DateDelivered.HasValue)
                    batches = batches.Where(b => b.DateDelivered >= FilterA.DateDelivered);

                if (!FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                    batches = batches.Where(b => b.DateDelivered <= FilterB.DateDelivered);

                if (FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                    batches = batches.Where(b =>
                        b.DateDelivered >= FilterA.DateDelivered && b.DateDelivered <= FilterB.DateDelivered);

                if (FilterA.Price > 0 && FilterB.Price == 0) batches = batches.Where(b => b.Price >= FilterA.Price);

                if (FilterA.Price == 0 && FilterB.Price > 0) batches = batches.Where(b => b.Price <= FilterB.Price);

                if (FilterA.Price > 0 && FilterB.Price > 0)
                    batches = batches.Where(b => b.Price >= FilterA.Price && b.Price <= FilterB.Price);

                if (FilterA.Workshop != null) batches = batches.Where(b => b.WorkshopId == FilterA.Workshop.Id);

                batches = batches.SortBy(sortBy, desk);

                rowsCount = batches.Count(); // общее кол-во строк для постраничного вывода

                batches = batches.Skip((page - 1) * count).Take(count);

                return batches.ToList();
            }
        }

        // ПОИСК ПОСТАВОК С ОПРЕДЕЛЕННОЙ ДЕТАЛЬЮ (ДЛЯ ЗАКАЗОВ)
        public static List<Batch> GetBatchesWithSparePart(Batch FilterA, Batch FilterB, SparePart sparePart, bool desk,
            string sortBy, int count, int page, out int rowsCount)
        {
            using (var db = new TechContext())
            {
                IEnumerable<Batch> batches = db.Batches.Where(b => b.DelTime == null).Include(b => b.Workshop);


                if (FilterA.Id != 0) batches = batches.Where(b => b.Id == FilterA.Id);

                if (FilterA.TrackNumber != null && FilterA.TrackNumber != string.Empty)
                    batches = batches.Where(b =>
                        b.TrackNumber.IndexOf(FilterA.TrackNumber, StringComparison.OrdinalIgnoreCase) > -1);

                // В ЗАКАЗ МОЖЕМ ДОБАВИТЬ ТОЛЬКО ПОДТВЕРЖДЕННУЮ / ПРИБЫВШУЮ
                batches = batches.Where(b => b.Status == BatchStatus.Подтверждена || b.Status == BatchStatus.Прибыла);

                if (FilterA.Workshop != null) batches = batches.Where(b => b.WorkshopId == FilterA.Workshop.Id);


                if (FilterA.DateDelivered.HasValue && !FilterB.DateDelivered.HasValue)
                    batches = batches.Where(b => b.DateDelivered >= FilterA.DateDelivered);

                if (!FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                    batches = batches.Where(b => b.DateDelivered <= FilterB.DateDelivered);

                if (FilterA.DateDelivered.HasValue && FilterB.DateDelivered.HasValue)
                    batches = batches.Where(b =>
                        b.DateDelivered >= FilterA.DateDelivered && b.DateDelivered <= FilterB.DateDelivered);

                if (FilterA.Price > 0 && FilterB.Price == 0) batches = batches.Where(b => b.Price >= FilterA.Price);

                if (FilterA.Price == 0 && FilterB.Price > 0) batches = batches.Where(b => b.Price <= FilterB.Price);

                if (FilterA.Price > 0 && FilterB.Price > 0)
                    batches = batches.Where(b => b.Price >= FilterA.Price && b.Price <= FilterB.Price);

                batches = batches.Where(b => b.CheckSparePart(sparePart));
                batches = batches.Where(b => b.GetCountLeft(sparePart) > 0);

                batches = batches.SortBy(sortBy, desk);

                rowsCount = batches.Count(); // общее кол-во строк для постраничного вывода

                batches = batches.Skip((page - 1) * count).Take(count);

                return batches.ToList();
            }
        }
    }

    [Table("BatchesSpareParts")]
    public class BatchSparePart
    {
        [Column("Id_Batch")] public int BatchId { get; set; }

        [Column("Id_Batch")] public Batch Batch { get; set; }

        [Column("Id_SparePart")] public int SparePartId { get; set; }

        [Column("Id_SparePart")] public SparePart SparePart { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}