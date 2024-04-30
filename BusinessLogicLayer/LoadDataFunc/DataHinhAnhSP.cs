using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataHinhAnhSP
    {
        public PictureProduct TimHinhAnhDuaTrenMaSanPham(string maSanPham)
        {
            using (var dataContext = new DataContext())
            {
                var picture = (from p in dataContext.Products
                               join pic in dataContext.PictureProducts on p.Picture_ID equals pic.Picture_ID
                               where p.Product_ID == maSanPham
                               select pic).FirstOrDefault();

                return picture;
            }
        }
    }
}
