using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Forms_TechServ
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
                // ПрОВЕРКУ ВЕСИТ ЛИ ЗАКАЗ АКТИВНЫЙ!!
                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
    }

    public static class ProductsList
    {
        public static Product GetById(int id, bool withNavProps)
        {
            using (TechContext db = new TechContext())
            {
                Product product = db.Products.Find(id);

                if (withNavProps)
                {
                    db.Entry(product).Reference(p => p.Client).Load();
                    db.Entry(product).Reference(p => p.Category).Load();
                }

                return product;

            }
        }

        public static List<Product> GetProducts(Product FilterA, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Product> products = db.Products.Where(p => p.DelTime == null).Include(p => p.Client).Include(p => p.Category);

                if(FilterA.Id != 0)
                {
                    products = products.Where(p => p.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    products = products.Where(p => p.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if(FilterA.Client != null)
                {
                    products = products.Where(p => p.ClientId == FilterA.Client.Id);
                }

                if(FilterA.Category != null)
                {
                    products = products.Where(p => p.CategoryId == FilterA.Category.Id);
                }

                products = products.SortBy(sortBy, desk);

                rowsCount = products.Count();

                products = products.Skip((page - 1) * count).Take(count);

                return products.ToList();
            }
        }
    }
}
