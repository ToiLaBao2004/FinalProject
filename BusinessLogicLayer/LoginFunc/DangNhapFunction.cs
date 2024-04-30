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
            using (var dataContext = new DataContext())
            {
                var query = from employee in dataContext.Employees
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

        public string LayName(string maDangNhap)
        {
            using (var dataContext = new DataContext())
            {
                var employee = dataContext.Employees.SingleOrDefault(emp => emp.Employee_ID == maDangNhap);

                if (employee != null)
                {
                    return employee.NameEmployee;
                }
                else
                {
                    return null;
                }
            }
        }

        public string LayChucVu(string maDangNhap)
        {
            using (var dataContext = new DataContext())
            {
                var employee = dataContext.Employees.SingleOrDefault(emp => emp.Employee_ID == maDangNhap);

                if (employee != null)
                {
                    return employee.RoleEmployee;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
