using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.spareParts;

namespace Forms_TechServ.classes.batches
{
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
}