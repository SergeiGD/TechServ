using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.categories
{
    public static class CategoriesList
    {
        public static Category GetById(int id, bool withNavProps)
        {
            using (var db = new TechContext())
            {
                var category = db.Categories.Find(id);

                if (withNavProps) db.Entry(category).Reference(c => c.ParentCategory).Load();

                return category;
            }
        }

        public static List<Category> GetCategories(Category FilterA, bool desk, string sortBy, int count, int page,
            out int rowsCount)
        {
            using (var db = new TechContext())
            {
                IEnumerable<Category> categories =
                    db.Categories.Include(c => c.ParentCategory).Where(c => c.DelTime == null);


                if (FilterA.Id != 0) categories = categories.Where(c => c.Id == FilterA.Id);

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                    categories = categories.Where(c =>
                        c.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);

                if (FilterA.ParentCategory != null)
                    categories = categories.Where(c => c.ParentCategoryId == FilterA.ParentCategory.Id);

                categories = categories.SortBy(sortBy, desk);


                rowsCount = categories.Count();

                categories = categories.Skip((page - 1) * count).Take(count);

                return categories.ToList();
            }
        }
    }
}