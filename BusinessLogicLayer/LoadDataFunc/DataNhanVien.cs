using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataNhanVien
    {
        public List<dynamic> LoadNhanVien()
        {
            using (var dataContext = new DataContext())
            {
                var employees = from e in dataContext.Employees
                                select new
                                {
                                    e.Employee_ID,
                                    e.NameEmployee,
                                    e.Birthday,
                                    e.Gender,
                                    e.PhoneNumber,
                                    e.RoleEmployee,
                                    e.Active
                                };

                return employees.ToList<dynamic>();
            }
        }

        public List<dynamic> TimNhanVienTheoMaNhanVienLoadVaoDGV(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var employees = from e in dataContext.Employees
                                where e.Employee_ID.Contains(keyword)
                                select new
                                {
                                    e.Employee_ID,
                                    e.NameEmployee,
                                    e.Birthday,
                                    e.Gender,
                                    e.PhoneNumber,
                                    e.RoleEmployee,
                                    e.Active
                                };

                return employees.ToList<dynamic>();
            }
        }

        public List<dynamic> TimNhanVienTheoSoDienThoaiLoadVaoDGV(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var employees = from e in dataContext.Employees
                                where e.PhoneNumber.Contains(keyword)
                                select new
                                {
                                    e.Employee_ID,
                                    e.NameEmployee,
                                    e.Birthday,
                                    e.Gender,
                                    e.PhoneNumber,
                                    e.RoleEmployee,
                                    e.Active
                                };

                return employees.ToList<dynamic>();
            }
        }
    }
}
