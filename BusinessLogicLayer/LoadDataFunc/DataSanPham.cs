using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataSanPham
    {
        public List<dynamic> LoadSanPham()
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

        public List<dynamic> TimSanPhamLoadVaoDGV(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var products = from p in dataContext.Products
                               where p.ProductName.Contains(keyword)
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


        public Product LaySanPhamTuMaSanPham(string Product_ID)
        {
            using (var dataContext = new DataContext())
            {
                var product = dataContext.Products.FirstOrDefault(p => p.Product_ID == Product_ID);

                return product;
            }
        }

        public void XoaSanPham(string Product_ID)
        {
            using (var dataContext = new DataContext())
            {
                var sanPham = dataContext.Products.FirstOrDefault(p => p.Product_ID == Product_ID);
                dataContext.Products.Remove(sanPham);

                dataContext.SaveChanges();
            }
        }

        public void AddOrUpdateSanPham(string Product_ID, string ProductName, int UnitPrice, string Brand_ID, string Category_ID)
        {
            using (var dataContext = new DataContext())
            {
                // Kiểm tra xem sản phẩm đã tồn tại trong cơ sở dữ liệu chưa
                var existingSanPham = dataContext.Products.FirstOrDefault(p => p.Product_ID == Product_ID);

                if (existingSanPham != null)
                {
                    // Sản phẩm đã tồn tại, cập nhật thông tin sản phẩm
                    existingSanPham.ProductName = ProductName;
                    existingSanPham.UnitPrice = UnitPrice;
                    existingSanPham.Brand_ID = Brand_ID;
                    existingSanPham.Category_ID = Category_ID;
                }
                else
                {
                    // Sản phẩm chưa tồn tại, tạo mới sản phẩm
                    var newSanPham = new Product
                    {
                        Product_ID = Product_ID,
                        ProductName = ProductName,
                        UnitPrice = UnitPrice,
                        Brand_ID = Brand_ID,
                        Category_ID = Category_ID,
                        Quantity = 0,
                        Picture_ID = null
                    };

                    // Thêm sản phẩm mới vào DbSet
                    dataContext.Products.Add(newSanPham);
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                dataContext.SaveChanges();
            }
        }
    }
}
