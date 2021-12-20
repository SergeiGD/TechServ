using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
{
    static class UserSession
    {

        static Employee employee;

        public static Employee LogIn(string phoneNum, string password)
        {
            using(TechContext db = new TechContext())
            {
                employee = db.Employees.Where(e => e.PhoneNum == phoneNum && e.Password == password).FirstOrDefault();

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

                if(employee.RoleId == 1)                // 1 - главный администратор системы, доступны все права
                {
                    return true;
                }

                if(db.RolesPermissions.Where(rp => rp.RoleId == employee.RoleId && rp.Permission.Code == code).FirstOrDefault() != null)
                {
                    return true;
                }


                return false;
            }
        }
    }
}
