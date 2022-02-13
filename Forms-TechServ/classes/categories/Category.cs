using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.databaseContext;

namespace Forms_TechServ.classes.categories
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("ParentCaregory")] public int? ParentCategoryId { get; set; }

        [Column("ParentCaregory")] public Category ParentCategory { get; set; }

        public DateTime? DelTime { get; set; }

        public bool AddCategory()
        {
            using (var db = new TechContext())
            {
                db.Categories.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditCategory()
        {
            using (var db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelCategory()
        {
            using (var db = new TechContext())
            {
                if (db.Categories.Where(c => c.ParentCategoryId == Id && c.DelTime == null).Count() == 0)
                {
                    DelTime = DateTime.Now;
                    db.Entry(this).State = EntityState.Modified;

                    foreach (var service in db.Services.Where(s => s.CategoryId == Id))
                    {
                        service.DelTime = DateTime.Now;
                        db.Entry(service).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public List<Category> GetParents()
        {
            using (var db = new TechContext())
            {
                var currentCat = db.Categories.Find(Id);
                var parents = new List<Category>();


                parents.Add(currentCat);


                while (currentCat != null)
                {
                    if (currentCat.Id != Id && currentCat.DelTime == null)
                        parents.Add(currentCat);
                    currentCat = db.Categories.Find(currentCat.ParentCategoryId);
                }

                return parents;
            }
        }


        // МЕТОД ДЛЯ ПОЛУЧЕНИЯ ПОЛНОЙ ВЕТКИ ВЫБРАННОЙ КАТЕГОРИИ
        public LinkedList<Category> GetWholeBranch()
        {
            using (var db = new TechContext())
            {
                var currentCat = db.Categories.Find(Id);
                var branch = new LinkedList<Category>();


                branch.AddFirst(currentCat);

                // Для начала идем вверх
                while (currentCat != null)
                {
                    if (currentCat.Id != Id)
                        branch.AddBefore(branch.First, currentCat);
                    currentCat = db.Categories.Find(currentCat.ParentCategoryId);
                }

                currentCat = db.Categories.Find(Id);


                // Затем добавляем дочерние узлы
                if (currentCat != null)
                {
                    Gethildern(currentCat);

                    void Gethildern(Category childCat)
                    {
                        foreach (var cat in db.Categories.Where(c =>
                                     c.ParentCategoryId == childCat.Id && c.DelTime == null))
                        {
                            branch.AddAfter(branch.Last, cat);
                            Gethildern(cat);
                        }
                    }
                }


                return branch;
            }
        }
    }
}