﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("ParentCaregory")]
        public int? ParentCategoryId { get; set; }

        [Column("ParentCaregory")]
        public Category ParentCategory { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddCategory()
        {
            using(TechContext db = new TechContext())
            {
                db.Categories.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditCategory()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelCategory()
        {
            using(TechContext db = new TechContext())
            {
                Category category = db.Categories.Where(c => c.ParentCategoryId == this.Id && c.DelTime == null).FirstOrDefault();
                if(category == null)
                {
                    this.DelTime = DateTime.Now;
                    db.Entry(this).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public bool LoadAllParents()
        {
            using (TechContext db = new TechContext())
            {
                Category cat = db.Categories.Find(this.Id);

                db.Entry(cat).Reference(c => c.ParentCategory).Load();

                while (cat.ParentCategory != null)
                {
                    cat = cat.ParentCategory;
                    db.Entry(cat).Reference(c => c.ParentCategory).Load();
                }
                
            }

            return true;
        }
    }

    public static class CategoriesList
    {
        public static Category GetById(int id, bool withNavProps)
        {
            using(TechContext db = new TechContext())
            {
                Category category = db.Categories.Find(id);

                if (withNavProps)
                {
                    db.Entry(category).Reference(c => c.ParentCategory).Load();
                }

                return category;
            }
        }
        public static List<Category> GetCategories(Category FilterA, bool onlyEndPoint, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using(TechContext db = new TechContext())
            {
                IEnumerable<Category> categories = db.Categories.Include(c => c.ParentCategory).Where(c => c.DelTime == null);

                

                if(FilterA.Id != 0)
                {
                    categories = categories.Where(c => c.Id == FilterA.Id);
                }

                if(FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    categories = categories.Where(c => c.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if(FilterA.ParentCategory != null)
                {
                    categories = categories.Where(c => c.ParentCategoryId == FilterA.ParentCategory.Id);
                }

                categories = categories.SortBy(sortBy, desk);

                //categories = (List<Category>)categories;

                

                if (onlyEndPoint)
                {
                    List<Category> endCats = new List<Category>();

                    foreach (Category cat in categories.ToList())
                    {
                        Category child = db.Categories.Where(c => c.ParentCategoryId == cat.Id && c.DelTime == null).FirstOrDefault();

                        if (child == null)
                        {
                            endCats.Add(cat);
                        }
                    }


                    rowsCount = endCats.Count();

                    endCats = endCats.Skip((page - 1) * count).Take(count).ToList();

                    return endCats;

                }

                rowsCount = categories.Count();

                categories = categories.Skip((page - 1) * count).Take(count);

                return categories.ToList();
            }
             
        }

        public static List<Category> GetEndCategories()
        {
            List<Category> categories = new List<Category>();

            using(TechContext db = new TechContext())
            {
                foreach (Category cat in db.Categories.Where(c => c.DelTime == null).ToList())
                {
                    Category child = db.Categories.Where(c => c.ParentCategoryId == cat.Id && c.DelTime == null).FirstOrDefault();

                    if (child == null)
                    {
                        categories.Add(cat);
                    }
                }
            }

            return categories;
        }
    }
}
