using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.products
{
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
