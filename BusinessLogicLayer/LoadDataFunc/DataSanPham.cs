using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataSanPham
    {
        public List<dynamic> loadSanPham()
        {
            using (var dataContext = new DataContext())
            {
                var products = from p in dataContext.Products
                               select new 
                               {
                                   p.Product_ID,
                                   p.ProductName,
                                   p.UnitPrice,
                                   p.Quantity
                               };

                return products.ToList<dynamic>();
            }
        }
    }
}
