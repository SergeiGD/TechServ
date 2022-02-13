using System;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.person;

namespace Forms_TechServ.classes.clients
{
    public class Client : Person
    {
        public bool AddClient()
        {
            using (var db = new TechContext())
            {
                db.Clients.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditClient()
        {
            using (var db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelClient()
        {
            using (var db = new TechContext())
            {
                var order = db.Orders.Include(o => o.Product).Where(o =>
                        o.Product.ClientId == Id && o.Status != OrderStatus.Canceled &&
                        o.Status != OrderStatus.Finished)
                    .FirstOrDefault();

                if (order != null) return false;

                foreach (var product in db.Products.Where(p => p.ClientId == Id))
                {
                    product.DelTime = DateTime.Now;
                    db.Entry(product).State = EntityState.Modified;
                }

                DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public decimal CalcSale()
        {
            using (var db = new TechContext())
            {
                var ordersCount = CountClientOrders();
                if (ordersCount > 10)
                    return 10;
                return ordersCount;
            }
        }

        public int CountClientOrders()
        {
            using (var db = new TechContext())
            {
                return db.Orders.Include(o => o.Product)
                    .Where(o => o.Product.ClientId == Id && o.Status == OrderStatus.Finished).Count();
            }
        }

        public string GetLastAddress()
        {
            using (var db = new TechContext())
            {
                var order = db.OrdersAtHome.Include(o => o.Product).Where(o => o.Product.ClientId == Id)
                    .OrderBy(o => o.DateStart).FirstOrDefault();
                if (order != null)
                    return order.Address;
                return "Не найден";
            }
        }
    }
}