using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataThuongHieu
    {
        public List<dynamic> LoadThuongHieu()
        {
            using (var dataContext = new DataContext())
            {
                var products = from b in dataContext.Brands
                               select new
                               {
                                   b.Brand_ID,
                                   b.BrandName
                               };

                return products.ToList<dynamic>();
            }
        }

        public Brand TimThuongHieuDuaTrenMaSanPham(string maSanPham)
        {
            using (var dataContext = new DataContext())
            {
                var brand = (from p in dataContext.Products
                             join b in dataContext.Brands on p.Brand_ID equals b.Brand_ID
                             where p.Product_ID == maSanPham
                             select b).FirstOrDefault();

                return brand;
            }
        }
    }
}
