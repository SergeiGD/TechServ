using System;
using System.Collections.Generic;
using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.helpers;

namespace Forms_TechServ.classes.clients
{
    public static class ClientsList
    {
        public static Client GetById(int id)
        {
            using (var db = new TechContext())
            {
                return db.Clients.Find(id);
            }
        }

        public static List<Client> GetClients(Client FilterA, int ordersFrom, int ordersUntil, bool desk, string sortBy,
            int count, int page, out int rowsCount)
        {
            using (var db = new TechContext())
            {
                IEnumerable<Client> clients = db.Clients.Where(c => c.DelTime == null);

                if (FilterA.Id != 0) clients = clients.Where(c => c.Id == FilterA.Id);

                if (FilterA.Name != null && FilterA.Name != string.Empty)
                    clients = clients.Where(w => w.Name.IndexOf(FilterA.Name, StringComparison.OrdinalIgnoreCase) > -1);

                if (FilterA.PhoneNum != null && FilterA.PhoneNum != string.Empty)
                    clients = clients.Where(w => w.PhoneNum.Contains(FilterA.PhoneNum));

                if (ordersFrom > 0 && ordersUntil == 0)
                    clients = clients.Where(c => c.CountClientOrders() >= ordersFrom);

                if (ordersFrom == 0 && ordersUntil > 0)
                    clients = clients.Where(c => c.CountClientOrders() <= ordersUntil);

                if (ordersFrom > 0 && ordersUntil > 0)
                    clients = clients.Where(c =>
                        c.CountClientOrders() >= ordersFrom && c.CountClientOrders() <= ordersUntil);


                clients = clients.SortBy(sortBy, desk);

                rowsCount = clients.Count();

                clients = clients.Skip((page - 1) * count).Take(count);

                return clients.ToList();
            }
        }
    }
}