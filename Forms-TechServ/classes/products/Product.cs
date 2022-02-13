using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.clients;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.orders;

namespace Forms_TechServ.classes.products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // ВЛАДЕЛЕЦ ТЕХНИКИ
        [Column("Id_Client")]
        public int ClientId { get; set; }
        [Column("Id_Client")]
        public Client Client { get; set; }

        // К КАКОЙ КАТЕГОРИИ ОТНОСИТСЯ ТЕХНИКА
        [Column("Id_Category")]
        public int CategoryId { get; set; }
        [Column("Id_Category")]
        public Category Category { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddProduct()
        {
            using(TechContext db = new TechContext())
            {
                db.Products.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditProduct()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelProduct()
        {
            using (TechContext db = new TechContext())
            {
                Order order = db.Orders.Where(o => o.ProductId == this.Id && o.Status != OrderStatus.Canceled && o.Status != OrderStatus.Finished).FirstOrDefault();

                if (order != null)
                {
                    return false;
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        
    }
}