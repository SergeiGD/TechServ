using System;
using System.Collections.Generic;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;
using Forms_TechServ.classes.workshops;

namespace Forms_TechServ.classes.spareParts
{
    public static class SparePartsList
    {
        public static SparePart GetById(int id)
        {
            using(TechContext db = new TechContext())
            {
                return db.SpareParts.Find(id);
            }
        }

        public static List<SparePart> GetSpareParts(SparePart FilterA, SparePart FilterB, Workshop workshop, int quantityFrom, int quantityUntil, bool desk, string sortBy, int count, int page, out int rowsCount)
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

                if(workshop != null)
                {
                    spareParts = spareParts.SortBy(sortBy, desk, workshop);

                    if (quantityFrom > 0 && quantityUntil == 0)
                    {
                        spareParts = spareParts.Where(s => s.GetCountInStock(workshop) >= quantityFrom);
                    }
                    if (quantityFrom == 0 && quantityUntil > 0)
                    {
                        spareParts = spareParts.Where(s => s.GetCountInStock(workshop) <= quantityUntil);
                    }
                    if (quantityFrom > 0 && quantityUntil > 0)
                    {
                        spareParts = spareParts.Where(s => s.GetCountInStock(workshop) >= quantityFrom && s.GetCountInStock(workshop) <= quantityUntil);
                    }
                }
                else
                {
                    spareParts = spareParts.SortBy(sortBy, desk);

                    if (quantityFrom > 0 && quantityUntil == 0)
                    {
                        spareParts = spareParts.Where(s => s.GetCountInStock() >= quantityFrom);
                    }
                    if (quantityFrom == 0 && quantityUntil > 0)
                    {
                        spareParts = spareParts.Where(s => s.GetCountInStock() <= quantityUntil);
                    }
                    if (quantityFrom > 0 && quantityUntil > 0)
                    {
                        spareParts = spareParts.Where(s => s.GetCountInStock() >= quantityFrom && s.GetCountInStock(workshop) <= quantityUntil);
                    }
                }
                

                rowsCount = spareParts.Count();

                spareParts = spareParts.Skip((page - 1) * count).Take(count);

                return spareParts.ToList();
            }
        }
    }


}
