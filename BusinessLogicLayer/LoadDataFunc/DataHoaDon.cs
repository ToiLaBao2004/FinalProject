using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataHoaDon
    {
        public List<dynamic> LoadHoaDon()
        {
            using (var dataContext = new DataContext())
            {
                var orders = from o in dataContext.Orders
                             select new
                             {
                                 o.Order_ID,
                                 o.Customers_ID,
                                 o.Employee_ID,
                                 o.OrderDate,
                                 o.TotalMoney,
                                 o.DiscountCode
                             };

                return orders.ToList<dynamic>();
            }
        }

        public List<dynamic> TimHoaDonLoadVaoDGV(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var orders = from o in dataContext.Orders
                             where o.Order_ID.Contains(keyword)
                             select new
                             {
                                 o.Order_ID,
                                 o.Customers_ID,
                                 o.Employee_ID,
                                 o.OrderDate,
                                 o.TotalMoney,
                                 o.DiscountCode
                             };

                return orders.ToList<dynamic>();
            }
        }

        public List<dynamic> TimHoaDonTheoNgayLoadVaoDGV(DateTime specificDate)
        {
            using (var dataContext = new DataContext())
            {
                var orders = from o in dataContext.Orders
                             where o.OrderDate.Year == specificDate.Year &&
                                   o.OrderDate.Month == specificDate.Month &&
                                   o.OrderDate.Day == specificDate.Day
                             select new
                             {
                                 o.Order_ID,
                                 o.Customers_ID,
                                 o.Employee_ID,
                                 o.OrderDate,
                                 o.TotalMoney,
                                 o.DiscountCode
                             };

                return orders.ToList<dynamic>();
            }
        }
    }
}
