using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
{
    public class Client : Person
    {
        public bool AddClient()
        {
            using (TechContext db = new TechContext())
            {
                db.Clients.Add(this);
                db.SaveChanges();
                return true;
            }
        }

        public bool EditClient()
        {
            using (TechContext db = new TechContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelClient()
        {
            using(TechContext db = new TechContext())
            {
                // ПРОВЕРЯТЬ ЕСТЬ ЛИ АКТИВНЫЕ ЗАКАЗЫ
                this.DelTime = DateTime.Now;
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
    }

    public static class ClientsList
    {
        public static Client GetById(int id)
        {
            using (TechContext db = new TechContext())
            {
                return db.Clients.Find(id);
            }
        }

        public static List<Client> GetClients(Client FilterA, Client FilterB, bool desk, string sortBy, int count, int page, out int rowsCount)
        {
            using (TechContext db = new TechContext())
            {
                IEnumerable<Client> clients = db.Clients.Where(c => c.DelTime == null);

                if(FilterA.Id != 0)
                {
                    clients = clients.Where(c => c.Id == FilterA.Id);
                }

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                {
                    clients = clients.Where(w => w.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);
                }

                if (FilterA.PhoneNum != null && FilterA.PhoneNum != string.Empty)
                {
                    clients = clients.Where(w => w.PhoneNum.Contains(FilterA.PhoneNum));                
                }

                // КОЛ-ВО ЗАКАЗОВ СДЕЛАТЬ

                clients = clients.SortBy(sortBy, desk);

                rowsCount = clients.Count();

                clients = clients.Skip((page - 1) * count).Take(count);

                return clients.ToList();
            }
        }
    }
}
