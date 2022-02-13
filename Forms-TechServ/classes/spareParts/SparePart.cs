using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.batches;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.workshops;

namespace Forms_TechServ.classes.spareParts
{
    public class SparePart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ClientPrepayment { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddSparePart()
        {
            using(TechContext db = new TechContext())
            {
                db.SpareParts.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditSparePart()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelSparePart()
        {
            using (TechContext db = new TechContext())
            {
                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

       

        public int GetCountInStock(Workshop workshop)
        {
            using (TechContext db = new TechContext())
            {
                int count = 0;

                IEnumerable<BatchSparePart> spareParts = db.BatchesSpareParts.Include(s => s.Batch).Where(s => s.SparePartId == this.Id && s.Batch.WorkshopId == workshop.Id && s.Batch.DelTime == null && s.Batch.Status == BatchStatus.Прибыла).Include(s => s.SparePart);

                foreach (BatchSparePart sparePart in spareParts)
                {
                    count += sparePart.Batch.GetCountLeft(sparePart.SparePart);
                }

                

                return count;
            }
        }

        public int GetCountInStock()
        {
            using (TechContext db = new TechContext())
            {
                int count = 0;

                IEnumerable<BatchSparePart> spareParts = db.BatchesSpareParts.Include(s => s.Batch).Where(s => s.SparePartId == this.Id && s.Batch.DelTime == null && s.Batch.Status == BatchStatus.Прибыла).Include(s => s.SparePart);


                foreach (BatchSparePart sparePart in spareParts)
                {
                    count += sparePart.Batch.GetCountLeft(sparePart.SparePart);
                }



                return count;
            }
        }

        public int GetCountInTransit(Workshop workshop)
        {
            using (TechContext db = new TechContext())
            {
                int count = 0;

                IEnumerable<BatchSparePart> spareParts = db.BatchesSpareParts.Include(s => s.Batch).Where(s => s.SparePartId == this.Id && s.Batch.WorkshopId == workshop.Id && s.Batch.DelTime == null && s.Batch.Status == BatchStatus.Подтверждена).Include(s => s.SparePart);

                foreach (BatchSparePart sparePart in spareParts)
                {

                    count += sparePart.Batch.GetCountLeft(sparePart.SparePart);
                }

                

                return count;
            }
        }

        public int GetCountInTransit()
        {
            using (TechContext db = new TechContext())
            {
                int count = 0;

                IEnumerable<BatchSparePart> spareParts = db.BatchesSpareParts.Include(s => s.Batch).Where(s => s.SparePartId == this.Id && s.Batch.DelTime == null && s.Batch.Status == BatchStatus.Подтверждена).Include(s => s.SparePart);

                foreach (BatchSparePart sparePart in spareParts)
                {
                    count += sparePart.Batch.GetCountLeft(sparePart.SparePart);
                }

                return count;
            }
        }
    }
}