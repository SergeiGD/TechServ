using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.clients;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.orders
{
    public static class OrdersList
    {
        public static Order GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                Order order = db.Orders.Find(id);

                if(order != null)
                {
                    db.Entry(order).Reference(o => o.Product).Load();
                    //db.Entry(order).Reference(o => o.Product.Client).Load();
                    db.Entry(order).Reference(o => o.Workshop).Load();
                    db.Entry(order).Reference(o => o.Master).Load();
                    db.Entry(order).Reference(o => o.Manager).Load();
                }

                return order;
            }
        }

        public static List<Order> GetOrders(Order FilterA, Order FilterB, Client client, bool activeOnly,/*List<OrderStatus> pickedStatuses,*/ bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(o => o.Workshop).Include(o => o.Product).Include(o => o.Product.Client).Include(o => o.Master).Include(o => o.Manager);

                if (FilterA.Id != 0)
                {
                    orders = orders.Where(o => o.Id == FilterA.Id);
                }

                if (client != null)
                {
                    orders = orders.Where(o => o.Product.ClientId == client.Id);
                }

                if (FilterA.Workshop != null)
                {
                    orders = orders.Where(o => o.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Product != null)
                {
                    orders = orders.Where(o => o.ProductId == FilterA.Product.Id);
                }

                if (FilterA.Master != null)
                {
                    orders = orders.Where(o => o.MasterId == FilterA.Master.Id);
                }

                if (FilterA.Manager != null)
                {
                    orders = orders.Where(o => o.ManagerId == FilterA.Manager.Id);
                }

                if (FilterA.Status != OrderStatus.Unknown)
                {
                    orders = orders.Where(o => o.Status == FilterA.Status);
                }

                if (activeOnly)
                {
                    orders = orders.Where(o => o.Status != OrderStatus.Finished && o.Status != OrderStatus.Canceled);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice == 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice);
                }

                if (FilterA.FinalPrice == 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice && o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired == 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired == 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired && o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade == 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade == 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade && o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.DateStart.HasValue && !FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart);
                }

                if (!FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart && o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateDiagnostic.HasValue && !FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic);
                }

                if (!FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic && o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateClientAnswer.HasValue && !FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer);
                }

                if (!FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer && o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateCancel.HasValue && !FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel);
                }

                if (!FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel && o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateRepaired.HasValue && !FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired);
                }

                if (!FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired && o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DatePaid.HasValue && !FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid);
                }

                if (!FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid && o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DateFinish.HasValue && !FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish);
                }

                if (!FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish <= FilterB.DateFinish);
                }

                if (FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish && o.DateFinish <= FilterB.DateFinish);
                }

                orders = orders.SortBy(sortBy, desk);

                rowsCount = orders.Count();                                  // общее кол-во строк для постраничного вывода

                orders = orders.Skip((page - 1) * count).Take(count);

                return orders.ToList();

            }
        }

        // ТОЛЬКО ЗАКАЗЫ В МАСТЕРСКОЙ
        public static List<Order> GetInOrders(Order FilterA, Order FilterB, Client client, bool activeOnly, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(o => o.Workshop).Include(o => o.Product).Include(o => o.Product.Client).Include(o => o.Master).Include(o => o.Manager).Where(o => !(o is OrderAtHome));

                if (FilterA.Id != 0)
                {
                    orders = orders.Where(o => o.Id == FilterA.Id);
                }

                if (client != null)
                {
                    orders = orders.Where(o => o.Product.ClientId == client.Id);
                }

                if (FilterA.Workshop != null)
                {
                    orders = orders.Where(o => o.WorkshopId == FilterA.Workshop.Id);
                }

                if (FilterA.Product != null)
                {
                    orders = orders.Where(o => o.ProductId == FilterA.Product.Id);
                }

                if(FilterA.Master != null)
                {
                    orders = orders.Where(o => o.MasterId == FilterA.Master.Id);
                }

                if(FilterA.Manager != null)
                {
                    orders = orders.Where(o => o.ManagerId == FilterA.Manager.Id);
                }

                if (FilterA.Status != OrderStatus.Unknown)
                {
                    orders = orders.Where(o => o.Status == FilterA.Status);
                }

                if (activeOnly)
                {
                    orders = orders.Where(o => o.Status != OrderStatus.Finished && o.Status != OrderStatus.Canceled);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice == 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice);
                }

                if (FilterA.FinalPrice == 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.FinalPrice > 0 && FilterB.FinalPrice > 0)
                {
                    orders = orders.Where(o => o.FinalPrice >= FilterA.FinalPrice && o.FinalPrice <= FilterB.FinalPrice);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired == 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired == 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentRequired > 0 && FilterB.PrepaymentRequired > 0)
                {
                    orders = orders.Where(o => o.PrepaymentRequired >= FilterA.PrepaymentRequired && o.PrepaymentRequired <= FilterB.PrepaymentRequired);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade == 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade == 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.PrepaymentMade > 0 && FilterB.PrepaymentMade > 0)
                {
                    orders = orders.Where(o => o.PrepaymentMade >= FilterA.PrepaymentMade && o.PrepaymentMade <= FilterB.PrepaymentMade);
                }

                if (FilterA.DateStart.HasValue && !FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart);
                }

                if (!FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateStart.HasValue && FilterB.DateStart.HasValue)
                {
                    orders = orders.Where(o => o.DateStart >= FilterA.DateStart && o.DateStart <= FilterB.DateStart);
                }

                if (FilterA.DateDiagnostic.HasValue && !FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic);
                }

                if (!FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateDiagnostic.HasValue && FilterB.DateDiagnostic.HasValue)
                {
                    orders = orders.Where(o => o.DateDiagnostic >= FilterA.DateDiagnostic && o.DateDiagnostic <= FilterB.DateDiagnostic);
                }

                if (FilterA.DateClientAnswer.HasValue && !FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer);
                }

                if (!FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateClientAnswer.HasValue && FilterB.DateClientAnswer.HasValue)
                {
                    orders = orders.Where(o => o.DateClientAnswer >= FilterA.DateClientAnswer && o.DateClientAnswer <= FilterB.DateClientAnswer);
                }

                if (FilterA.DateCancel.HasValue && !FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel);
                }

                if (!FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateCancel.HasValue && FilterB.DateCancel.HasValue)
                {
                    orders = orders.Where(o => o.DateCancel >= FilterA.DateCancel && o.DateCancel <= FilterB.DateCancel);
                }

                if (FilterA.DateRepaired.HasValue && !FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired);
                }

                if (!FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DateRepaired.HasValue && FilterB.DateRepaired.HasValue)
                {
                    orders = orders.Where(o => o.DateRepaired >= FilterA.DateRepaired && o.DateRepaired <= FilterB.DateRepaired);
                }

                if (FilterA.DatePaid.HasValue && !FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid);
                }

                if (!FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DatePaid.HasValue && FilterB.DatePaid.HasValue)
                {
                    orders = orders.Where(o => o.DatePaid >= FilterA.DatePaid && o.DatePaid <= FilterB.DatePaid);
                }

                if (FilterA.DateFinish.HasValue && !FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish);
                }

                if (!FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish <= FilterB.DateFinish);
                }

                if (FilterA.DateFinish.HasValue && FilterB.DateFinish.HasValue)
                {
                    orders = orders.Where(o => o.DateFinish >= FilterA.DateFinish && o.DateFinish <= FilterB.DateFinish);
                }

                orders = orders.SortBy(sortBy, desk);

                rowsCount = orders.Count();                                  // общее кол-во строк для постраничного вывода

                orders = orders.Skip((page - 1) * count).Take(count);

                return orders.ToList();

            }
        }
    }
}