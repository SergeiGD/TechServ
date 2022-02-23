using System.Linq;
using Forms_TechServ.classes.databaseContext;
using Forms_TechServ.classes.employees;

namespace Forms_TechServ.classes.UserSession
{
    static class UserSession
    {

        static Employee employee;

        public static Employee LogIn(string phoneNum, string password)
        {
            using(TechContext db = new TechContext())
            {
                employee = db.Employees.Where(e => e.PhoneNum == phoneNum && e.Password == password && e.DelTime == null).FirstOrDefault();

                return employee;
            }
        }

        public static Employee GetLoggedInUser()
        {
            return employee;
        }

        public static bool Can(string code)
        {
            using (TechContext db = new TechContext())
            {

                if(employee == null)
                {
                    return false;
                }

                if (employee.RoleId == 1) // 1 - главный администратор системы, доступны все права
                {
                    return true;
                }

                if (db.RolesPermissions.Any(rp => rp.RoleId == employee.RoleId && rp.Permission.Code == code))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
