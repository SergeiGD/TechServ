using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Forms_TechServ.classes.categories;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.orders;
using Forms_TechServ.classes.visits;

namespace Forms_TechServ.classes.employees
{
    public class Master : Employee
    {
        public bool AddMaster()
        {
            using (TechContext db = new TechContext())
            {
                if (db.Employees.Where(e => e.DelTime == null && e.PhoneNum == this.PhoneNum && e.Id != this.Id).Count() != 0)
                {
                    return false;
                }

                db.Masters.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool DelMaster()
        {
            using (TechContext db = new TechContext())
            {
                // ЕСТЬ ЛИ АКТИВНЫЕ ЗАКАЗЫ
                Order order = db.Orders.Where(o => o.MasterId == this.Id && o.Status != OrderStatus.Canceled && o.Status != OrderStatus.Finished).FirstOrDefault();

                if(order != null)
                {
                    return false;
                }

                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
               
            }
        }

        

        public bool EditMaster()
        {
            using (TechContext db = new TechContext())
            {
                if (db.Employees.Where(e => e.DelTime == null && e.PhoneNum == this.PhoneNum && e.Id != this.Id).Count() != 0)
                {
                    return false;
                }

                db.Entry(this).State = EntityState.Modified;
                
                db.SaveChanges();
                


                return true;
                
            }
        }

        public List<Visit> GetMasterVisits()
        {
            using (TechContext db = new TechContext())
            {
                return db.Visits.Include(v => v.Order).Where(v => v.Order.MasterId == this.Id && v.DelTime == null).ToList();
            }
        }

        public bool AddMasterCategory(Category category)
        {
            using (TechContext db = new TechContext())
            {

                if (!CheckMasterCategory(category))
                {

                    MastersCategories masterCat = new MastersCategories()
                    {
                        MasterId = this.Id,
                        CategoryId = category.Id
                    };



                    CleanChildern(category);

                    db.MastersCategories.Add(new MastersCategories()
                    {
                        MasterId = this.Id,
                        CategoryId = category.Id
                    });

                    db.SaveChanges();


                    // рекурсивная локальная функция, которая удалят дочерние элементы, когда добавляется категория более выского уровня (узла)
                    void CleanChildern(Category currentCat)
                    {
                        foreach (Category cat in db.Categories.Where(c => c.ParentCategoryId == currentCat.Id && c.DelTime == null))
                        {
                            CleanChildern(cat);
                            db.MastersCategories.RemoveRange(db.MastersCategories.Where(c => c.CategoryId == cat.Id && c.MasterId == this.Id));
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
                
                
            }
        }

        public bool DelMasterCategory(Category category)
        {
            using (TechContext db = new TechContext())
            {
                MastersCategories catToDelete = db.MastersCategories.Find(this.Id, category.Id);
                if(catToDelete != null)
                {
                    db.MastersCategories.Remove(catToDelete);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
               
            }
        }

        public List<Category> GetMasterCategories(int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Category> categories = from c in db.MastersCategories.Include(c => c.Category)
                    where c.MasterId == this.Id && c.Category.DelTime == null
                    select c.Category;

                rowsCount = categories.Count();

                categories = categories.Skip((page - 1) * count).Take(count);
                //categories = 
                return categories.ToList();
            }
        }

        public bool CheckMasterCategory(Category category)
        {
            using (TechContext db = new TechContext())
            {
                MastersCategories masterCat = null;
                Category pickedCat = category;

                
                while (pickedCat != null && masterCat == null)
                {
                    masterCat = db.MastersCategories.Find(this.Id, pickedCat.Id);
                    pickedCat = db.Categories.Where(c => c.Id == pickedCat.ParentCategoryId && c.DelTime == null).FirstOrDefault();
                }
                

                if (masterCat != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

    }
}