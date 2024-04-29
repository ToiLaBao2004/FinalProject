using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoginFunc
{
    public class DangNhapFunction
    {
        public bool DangNhap(string maDangNhap, string passWord)
        {
            using (var dataContex = new DataContext())
            {
                var query = from employee in dataContex.Employees
                            where employee.Employee_ID == maDangNhap
                            select employee;

                var result = query.FirstOrDefault();

                if (result != null && result.PassWordAccount == passWord)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
