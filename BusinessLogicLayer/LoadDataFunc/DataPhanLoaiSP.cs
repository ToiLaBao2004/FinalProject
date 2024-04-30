using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataPhanLoaiSP
    {
        public List<dynamic> LoadLoaiSanPham()
        {
            using (var dataContext = new DataContext())
            {
                var products = from c in dataContext.Categories
                               select new
                               {
                                   c.Category_ID,
                                   c.CategoryName
                               };

                return products.ToList<dynamic>();
            }
        }

        public Category TimLoaiSPDuaTrenMaSanPham(string maSanPham)
        {
            using (var dataContext = new DataContext())
            {
                var category = (from p in dataContext.Products
                                join c in dataContext.Categories on p.Category_ID equals c.Category_ID
                                where p.Product_ID == maSanPham
                                select c).FirstOrDefault();

                return category;
            }
        }

        public List<dynamic> LoadSanPhamTheoLoai(string maLoaiSP)
        {
            using (var dataContext = new DataContext())
            {
                var products = from p in dataContext.Products
                               join c in dataContext.Categories on p.Category_ID equals c.Category_ID
                               where p.Category_ID == maLoaiSP
                               select new { p.Product_ID, p.ProductName, p.UnitPrice, p.Quantity };

                return products.ToList<dynamic>();
            }
        }
    }
}
