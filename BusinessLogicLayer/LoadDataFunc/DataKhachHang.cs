using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataKhachHang
    {
        public List<dynamic> LoadKhachHang()
        {
            using (var dataContext = new DataContext())
            {
                var customers = from c in dataContext.Customers
                                select new
                                {
                                    c.Customers_ID,
                                    c.PhoneNumber,
                                    c.NameCustomer,
                                    c.Birthday,
                                    c.Gender,
                                    c.AddressCustomer,
                                    c.TotalMoney
                                };

                return customers.ToList<dynamic>();
            }
        }

        public List<dynamic> TimKhachHangTheoMaKhachHangLoadVaoDGV(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var customers = from c in dataContext.Customers
                                where c.Customers_ID.Contains(keyword)
                                select new
                                {
                                    c.Customers_ID,
                                    c.PhoneNumber,
                                    c.NameCustomer,
                                    c.Birthday,
                                    c.Gender,
                                    c.AddressCustomer,
                                    c.TotalMoney
                                };

                return customers.ToList<dynamic>();
            }
        }

        public List<dynamic> TimKhachHangTheoSDTLoadVaoDGV(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var customers = from c in dataContext.Customers
                                where c.PhoneNumber.Contains(keyword)
                                select new
                                {
                                    c.Customers_ID,
                                    c.PhoneNumber,
                                    c.NameCustomer,
                                    c.Birthday,
                                    c.Gender,
                                    c.AddressCustomer,
                                    c.TotalMoney
                                };

                return customers.ToList<dynamic>();
            }
        }
    }
}
