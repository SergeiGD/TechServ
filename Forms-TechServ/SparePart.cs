using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
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
    }


    public static class SparePartsList
    {
        public static SparePart GetById(int id)
        {
            using(TechContext db = new TechContext())
            {
                return db.SpareParts.Find(id);
            }
        }

        public static List<SparePart> GetSpareParts(SparePart FilterA, SparePart FilterB, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using(TechContext db = new TechContext())
            {
                IEnumerable<SparePart> spareParts = db.SpareParts.Where(s => s.DelTime == null);

                if(FilterA.Id != 0)
                {
                    spareParts = spareParts.Where(s => s.Id == FilterA.Id);
                }

                if(FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    spareParts = spareParts.Where(s => s.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                // СДЕЛАЕМ -1 -> БЕЗ ПРЕДОПЛАТЫ, А 0 -> СКОЛЬКО УГОДНО 
                if (FilterA.ClientPrepayment > 0 && FilterB.ClientPrepayment == 0)                                      // от указанной до любой
                {
                    spareParts = spareParts.Where(s => s.ClientPrepayment >= FilterA.ClientPrepayment);
                }

                if(FilterA.ClientPrepayment == 0 && FilterB.ClientPrepayment > 0)                                       // от любой до указанной
                {
                    spareParts = spareParts.Where(s => s.ClientPrepayment <= FilterB.ClientPrepayment);
                }

                if(FilterA.ClientPrepayment > 0 && FilterB.ClientPrepayment > 0)                                        // от указанной до указанной
                {
                    spareParts = spareParts.Where(s => s.ClientPrepayment >= FilterA.ClientPrepayment && s.ClientPrepayment <= FilterB.ClientPrepayment);
                }

                if(FilterA.ClientPrepayment == -1)                                                                      // без предоплаты
                {
                    spareParts = spareParts.Where(s => s.ClientPrepayment == 0);
                }

                // НАЛИИЕ 
                // РЕАЛИЗОВАТЬ
                // !!

                spareParts = spareParts.SortBy(sortBy, desk);

                rowsCount = spareParts.Count();

                spareParts = spareParts.Skip((page - 1) * count).Take(count);

                return spareParts.ToList();
            }
        }
    }


}
