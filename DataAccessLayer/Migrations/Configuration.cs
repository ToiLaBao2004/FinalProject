namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Context;
    using DataAccessLayer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //  Cấu hình cho quá trình migration của Entity Framework
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            //  Tắt tính năng migration tự động
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //  Phương thức này sẽ được gọi sau khi thực hiện migrations lên phiên bản mới nhất của cơ sở dữ liệu.

            //  Bạn có thể sử dụng phương thức mở rộng DbSet<T>.AddOrUpdate()
            //  để tránh tạo dữ liệu gốc trùng lặp.

            //  Gọi phương thức Seed() của lớp cha để thực hiện công việc khởi tạo ban đầu.
            base.Seed(context);

            //  Thêm dữ liệu mẫu (seed data) vào bảng Brands
            var brands = new[]
            {
                new Brand { Brand_ID = "YNX", BrandName = "Yonex" },
                new Brand { Brand_ID = "LN", BrandName = "Lining" },
                new Brand { Brand_ID = "ADD", BrandName = "Adidas" },
                new Brand { Brand_ID = "KMT", BrandName = "Kamito" },
                new Brand { Brand_ID = "KWS", BrandName = "Kawasaki" },
                new Brand { Brand_ID = "NIK", BrandName = "Nike" },
                new Brand { Brand_ID = "PKN", BrandName = "Prokennex" },
                new Brand { Brand_ID = "PN", BrandName = "Pan" }
            };
            context.Brands.AddOrUpdate(b => b.Brand_ID, brands);

            //  Thêm dữ liệu mẫu (seed data) vào bảng Categories
            var categories = new[]
            {
                new Category { Category_ID = "ACL", CategoryName = "Áo cầu lông" },
                new Category { Category_ID = "BĐBĐ", CategoryName = "Bộ đồ bóng đá" },
                new Category { Category_ID = "GBĐ", CategoryName = "Giày bóng đá" },
                new Category { Category_ID = "GCL", CategoryName = "Giày cầu lông" },
                new Category { Category_ID = "PK", CategoryName = "Phụ kiện" },
                new Category { Category_ID = "QCL", CategoryName = "Quần cầu lông" },
                new Category { Category_ID = "VCL", CategoryName = "Vợt cầu lông" }
            };
            context.Categories.AddOrUpdate(c => c.Category_ID, categories);

            //  Thêm dữ liệu mẫu (seed data) vào bảng PictureProducts
            var pictureNames = new[]
            {
                "AocaulongYonexDen.jpg",
                "AocaulongYonexTrang.jpg",
                "KamitoTienMinhLegend.jpg",
                "KamitoVTTGowo.jpg",
                "Kawasaki065Do.jpg",
                "Kawasaki065Trang.jpg",
                "LiningAxforce70.jpg",
                "LiningAxforce80.jpg",
                "LiningAxforce90.jpg",
                "LiningChenLongAYZU011-1.jpg",
                "OngcaulongLining.jpg",
                "OngcaulongYonex.jpg",
                "PanPatriotEVOPodTFDo.jpg",
                "PanPatriotEVOPodTFTrang.jpg",
                "PanPatriotEVOPodTFVang.jpg",
                "ProKennexPowerPro705.jpg",
                "ProKennexThunder7004.jpg",
                "QuancancaulongLining.jpg",
                "QuancancaulongYonex.jpg",
                "YonexAstrox88D2018.jpg",
                "YonexAstrox88DPro2022.jpg",
                "YonexAstrox88S2018.jpg",
                "YonexAstrox88SPro2022.jpg",
                "YonexAstrox99Navy2020.jpg",
                "YonexAstrox99Pro2022.jpg",
                "YonexEclipsionZ3MenNavy.jpg",
                "YonexSHB65Z3WhiteTiger.jpg",
                "YonexSHB65Z3WomanNavy.jpg",
                "AdidasXCrazyfastMessi.jpg",
                "AobongdaNikekhonglogoDen.jpg",
                "AobongdaNikekhonglogoTrang.jpg",
                "NikeGalaxyCR7.jpg",
                "YonexEclipsionZ3WomanWhite.jpg",
                "QuanCauLongYonexTrang.jpg",
                "QuanCauLongYonexDen.jpg"
            };
            foreach (var picture in pictureNames)
            {
                var pictureProduct = new PictureProduct { PictureName = picture };
                context.PictureProducts.AddOrUpdate(pictureProduct);
            }

            //  Thêm dữ liệu mẫu (seed data) vào bảng Products
            var products = new[]
            {
                new Product { Product_ID = "88D2018", ProductName = "Yonex Astrox 88D 2018", UnitPrice = 6500000, Quantity = 10, Brand_ID = "YNX", Category_ID = "VCL", Picture_ID = 20 },
                new Product { Product_ID = "88DP2022", ProductName = "Yonex Astrox 88D Pro 2022", UnitPrice = 4900000, Quantity = 0, Brand_ID = "YNX", Category_ID = "VCL", Picture_ID = 21 },
                new Product { Product_ID = "88DS2022", ProductName = "Yonex Astrox 88S Pro 2022", UnitPrice = 4800000, Quantity = 0, Brand_ID = "YNX", Category_ID = "VCL", Picture_ID = 23 },
                new Product { Product_ID = "88S2018", ProductName = "Yonex Astrox 88S 2018", UnitPrice = 6400000, Quantity = 0, Brand_ID = "YNX", Category_ID = "VCL", Picture_ID = 22 },
                new Product { Product_ID = "99NAVY2020", ProductName = "Yonex Astrox 99 Navy 2020", UnitPrice = 5000000, Quantity = 10, Brand_ID = "YNX", Category_ID = "VCL", Picture_ID = 24 },
                new Product { Product_ID = "99PRO2022", ProductName = "Yonex Astrox 99 Pro 2022", UnitPrice = 5500000, Quantity = 0, Brand_ID = "YNX", Category_ID = "VCL", Picture_ID = 25 },
                new Product { Product_ID = "ACLYĐL", ProductName = "Áo cầu lông Yonex Đen Size L", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 1 },
                new Product { Product_ID = "ACLYĐM", ProductName = "Áo cầu lông Yonex Đen Size M", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 1 },
                new Product { Product_ID = "ACLYĐS", ProductName = "Áo cầu lông Yonex Đen Size S", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 1 },
                new Product { Product_ID = "ACLYĐXL", ProductName = "Áo cầu lông Yonex Đen Size XL", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 1 },
                new Product { Product_ID = "ACLYĐXXL", ProductName = "Áo cầu lông Yonex Đen Size XXL", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 1 },
                new Product { Product_ID = "ACLYTL", ProductName = "Áo cầu lông Yonex Trắng Size L", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 2 },
                new Product { Product_ID = "ACLYTM", ProductName = "Áo cầu lông Yonex Trắng Size M", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 2 },
                new Product { Product_ID = "ACLYTS", ProductName = "Áo cầu lông Yonex Trắng Size S", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 2 },
                new Product { Product_ID = "ACLYTXL", ProductName = "Áo cầu lông Yonex Trắng Size XL", UnitPrice = 200000, Quantity = 10, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 2 },
                new Product { Product_ID = "ACLYTXXL", ProductName = "Áo cầu lông Yonex Trắng Size XXL", UnitPrice = 200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "ACL", Picture_ID = 2 },
                new Product { Product_ID = "ANKLĐL", ProductName = "Áo bóng đá Nike không logo Đen Size L", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 30 },
                new Product { Product_ID = "ANKLĐM", ProductName = "Áo bóng đá Nike không logo Đen Size M", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 30 },
                new Product { Product_ID = "ANKLĐS", ProductName = "Áo bóng đá Nike không logo Đen Size S", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 30 },
                new Product { Product_ID = "ANKLĐXL", ProductName = "Áo bóng đá Nike không logo Đen Size XL", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 30 },
                new Product { Product_ID = "ANKLĐXXL", ProductName = "Áo bóng đá Nike không logo Đen Size XXL", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 30 },
                new Product { Product_ID = "ANKLTL", ProductName = "Áo bóng đá Nike không logo Trắng Size L", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 31 },
                new Product { Product_ID = "ANKLTM", ProductName = "Áo bóng đá Nike không logo Trắng Size M", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 31 },
                new Product { Product_ID = "ANKLTS", ProductName = "Áo bóng đá Nike không logo Trắng Size S", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 31 },
                new Product { Product_ID = "ANKLTXL", ProductName = "Áo bóng đá Nike không logo Trắng Size XL", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 31 },
                new Product { Product_ID = "ANKLTXXL", ProductName = "Áo bóng đá Nike không logo Trắng Size XXL", UnitPrice = 150000, Quantity = 0, Brand_ID = "NIK", Category_ID = "BĐBĐ", Picture_ID = 31 },
                new Product { Product_ID = "AX70", ProductName = "Lining Axforce 70", UnitPrice = 4500000, Quantity = 0, Brand_ID = "LN", Category_ID = "VCL", Picture_ID = 7 },
                new Product { Product_ID = "AX80", ProductName = "Lining Axforce 80", UnitPrice = 5000000, Quantity = 0, Brand_ID = "LN", Category_ID = "VCL", Picture_ID = 8 },
                new Product { Product_ID = "AX90", ProductName = "Lining Axforce 90", UnitPrice = 5400000, Quantity = 0, Brand_ID = "LN", Category_ID = "VCL", Picture_ID = 9 },
                new Product { Product_ID = "AXM39", ProductName = "Adidas X Crazyfast Messi Size 39", UnitPrice = 2000000, Quantity = 0, Brand_ID = "ADD", Category_ID = "GBĐ", Picture_ID = 29 },
                new Product { Product_ID = "AXM40", ProductName = "Adidas X Crazyfast Messi Size 40", UnitPrice = 2000000, Quantity = 0, Brand_ID = "ADD", Category_ID = "GBĐ", Picture_ID = 29 },
                new Product { Product_ID = "AXM41", ProductName = "Adidas X Crazyfast Messi Size 41", UnitPrice = 2000000, Quantity = 0, Brand_ID = "ADD", Category_ID = "GBĐ", Picture_ID = 29 },
                new Product { Product_ID = "AXM42", ProductName = "Adidas X Crazyfast Messi Size 42", UnitPrice = 2000000, Quantity = 0, Brand_ID = "ADD", Category_ID = "GBĐ", Picture_ID = 29 },
                new Product { Product_ID = "AXM43", ProductName = "Adidas X Crazyfast Messi Size 43", UnitPrice = 2000000, Quantity = 0, Brand_ID = "ADD", Category_ID = "GBĐ", Picture_ID = 29 },
                new Product { Product_ID = "AXM44", ProductName = "Adidas X Crazyfast Messi Size 44", UnitPrice = 2000000, Quantity = 0, Brand_ID = "ADD", Category_ID = "GBĐ", Picture_ID = 29 },
                new Product { Product_ID = "KMTTML", ProductName = "Kamito Tiến Minh Legend", UnitPrice = 2300000, Quantity = 0, Brand_ID = "KMT", Category_ID = "VCL", Picture_ID = 3 },
                new Product { Product_ID = "KMTVTT", ProductName = "Kamito VTT Gowo", UnitPrice = 1700000, Quantity = 0, Brand_ID = "KMT", Category_ID = "VCL", Picture_ID = 4 },
                new Product { Product_ID = "KWS065Đ39", ProductName = "Kawasaki 065 Đỏ Size 39", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 5 },
                new Product { Product_ID = "KWS065Đ40", ProductName = "Kawasaki 065 Đỏ Size 40", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 5 },
                new Product { Product_ID = "KWS065Đ41", ProductName = "Kawasaki 065 Đỏ Size 41", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 5 },
                new Product { Product_ID = "KWS065Đ42", ProductName = "Kawasaki 065 Đỏ Size 42", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 5 },
                new Product { Product_ID = "KWS065Đ43", ProductName = "Kawasaki 065 Đỏ Size 43", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 5 },
                new Product { Product_ID = "KWS065Đ44", ProductName = "Kawasaki 065 Đỏ Size 44", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 5 },
                new Product { Product_ID = "KWS065T39", ProductName = "Kawasaki 065 Trắng Size 39", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 6 },
                new Product { Product_ID = "KWS065T40", ProductName = "Kawasaki 065 Trắng Size 40", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 6 },
                new Product { Product_ID = "KWS065T41", ProductName = "Kawasaki 065 Trắng Size 41", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 6 },
                new Product { Product_ID = "KWS065T42", ProductName = "Kawasaki 065 Trắng Size 42", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 6},
                new Product { Product_ID = "KWS065T43", ProductName = "Kawasaki 065 Trắng Size 43", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 6 },
                new Product { Product_ID = "KWS065T44", ProductName = "Kawasaki 065 Trắng Size 44", UnitPrice = 800000, Quantity = 0, Brand_ID = "KWS", Category_ID = "GCL", Picture_ID = 6 },
                new Product { Product_ID = "LCA39", ProductName = "Lining ChenLong AYZU011-1 Size 39", UnitPrice = 2650000, Quantity = 0, Brand_ID = "LN", Category_ID = "GCL", Picture_ID = 10 },
                new Product { Product_ID = "LCA40", ProductName = "Lining ChenLong AYZU011-1 Size 40", UnitPrice = 2650000, Quantity = 0, Brand_ID = "LN", Category_ID = "GCL", Picture_ID = 10 },
                new Product { Product_ID = "LCA41", ProductName = "Lining ChenLong AYZU011-1 Size 41", UnitPrice = 2650000, Quantity = 0, Brand_ID = "LN", Category_ID = "GCL", Picture_ID = 10 },
                new Product { Product_ID = "LCA42", ProductName = "Lining ChenLong AYZU011-1 Size 42", UnitPrice = 2650000, Quantity = 0, Brand_ID = "LN", Category_ID = "GCL", Picture_ID = 10 },
                new Product { Product_ID = "LCA43", ProductName = "Lining ChenLong AYZU011-1 Size 43", UnitPrice = 2650000, Quantity = 0, Brand_ID = "LN", Category_ID = "GCL", Picture_ID = 10 },
                new Product { Product_ID = "LCA44", ProductName = "Lining ChenLong AYZU011-1 Size 44", UnitPrice = 2650000, Quantity = 0, Brand_ID = "LN", Category_ID = "GCL", Picture_ID = 10 },
                new Product { Product_ID = "NGCR39", ProductName = "Nike Galaxy CR7 Size 39", UnitPrice = 2000000, Quantity = 0, Brand_ID = "NIK", Category_ID = "GBĐ", Picture_ID = 32 },
                new Product { Product_ID = "NGCR40", ProductName = "Nike Galaxy CR7 Size 40", UnitPrice = 2000000, Quantity = 0, Brand_ID = "NIK", Category_ID = "GBĐ", Picture_ID = 32 },
                new Product { Product_ID = "NGCR41", ProductName = "Nike Galaxy CR7 Size 41", UnitPrice = 2000000, Quantity = 0, Brand_ID = "NIK", Category_ID = "GBĐ", Picture_ID = 32 },
                new Product { Product_ID = "NGCR42", ProductName = "Nike Galaxy CR7 Size 42", UnitPrice = 2000000, Quantity = 0, Brand_ID = "NIK", Category_ID = "GBĐ", Picture_ID = 32 },
                new Product { Product_ID = "NGCR43", ProductName = "Nike Galaxy CR7 Size 43", UnitPrice = 2000000, Quantity = 0, Brand_ID = "NIK", Category_ID = "GBĐ", Picture_ID = 32 },
                new Product { Product_ID = "NGCR44", ProductName = "Nike Galaxy CR7 Size 44", UnitPrice = 2000000, Quantity = 0, Brand_ID = "NIK", Category_ID = "GBĐ", Picture_ID = 32 },
                new Product { Product_ID = "PKPP705", ProductName = "Pro Kennex Power Pro 705", UnitPrice = 800000, Quantity = 0, Brand_ID = "PKN", Category_ID = "VCL", Picture_ID = 16 },
                new Product { Product_ID = "PKT7004", ProductName = "Pro Kennex Thunder 7004", UnitPrice = 900000, Quantity = 0, Brand_ID = "PKN", Category_ID = "VCL", Picture_ID = 17 },
                new Product { Product_ID = "PPTEP39ĐTF", ProductName = "Pan Patriot EVO Pod TF Đỏ Size 39", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ",  Picture_ID = 13 },
                new Product { Product_ID = "PPTEP39TIC", ProductName = "Pan Patriot EVO Pod IC Trắng Size 39", UnitPrice = 610000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP39TTF", ProductName = "Pan Patriot EVO Pod TF Trắng Size 39", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP39VTF", ProductName = "Pan Patriot EVO Pod TF Vàng Size 39", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 15 },
                new Product { Product_ID = "PPTEP40ĐTF", ProductName = "Pan Patriot EVO Pod TF Đỏ Size 40", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 13 },
                new Product { Product_ID = "PPTEP40TIC", ProductName = "Pan Patriot EVO Pod IC Trắng Size 40", UnitPrice = 610000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP40TTF", ProductName = "Pan Patriot EVO Pod TF Trắng Size 40", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP40VTF", ProductName = "Pan Patriot EVO Pod TF Vàng Size 40", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 15 },
                new Product { Product_ID = "PPTEP41ĐTF", ProductName = "Pan Patriot EVO Pod TF Đỏ Size 41", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 13 },
                new Product { Product_ID = "PPTEP41TIC", ProductName = "Pan Patriot EVO Pod IC Trắng Size 41", UnitPrice = 610000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP41TTF", ProductName = "Pan Patriot EVO Pod TF Trắng Size 41", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP41VTF", ProductName = "Pan Patriot EVO Pod TF Vàng Size 41", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 15 },
                new Product { Product_ID = "PPTEP42ĐTF", ProductName = "Pan Patriot EVO Pod TF Đỏ Size 42", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 13 },
                new Product { Product_ID = "PPTEP42TIC", ProductName = "Pan Patriot EVO Pod IC Trắng Size 42", UnitPrice = 610000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP42TTF", ProductName = "Pan Patriot EVO Pod TF Trắng Size 42", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP42VTF", ProductName = "Pan Patriot EVO Pod TF Vàng Size 42", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 15 },
                new Product { Product_ID = "PPTEP43ĐTF", ProductName = "Pan Patriot EVO Pod TF Đỏ Size 43", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 13 },
                new Product { Product_ID = "PPTEP43TIC", ProductName = "Pan Patriot EVO Pod IC Trắng Size 43", UnitPrice = 610000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP43TTF", ProductName = "Pan Patriot EVO Pod TF Trắng Size 43", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP43VTF", ProductName = "Pan Patriot EVO Pod TF Vàng Size 43", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 15 },
                new Product { Product_ID = "PPTEP44ĐTF", ProductName = "Pan Patriot EVO Pod TF Đỏ Size 44", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 13 },
                new Product { Product_ID = "PPTEP44TIC", ProductName = "Pan Patriot EVO Pod IC Trắng Size 44", UnitPrice = 610000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP44TTF", ProductName = "Pan Patriot EVO Pod TF Trắng Size 44", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 14 },
                new Product { Product_ID = "PPTEP44VTF", ProductName = "Pan Patriot EVO Pod TF Vàng Size 44", UnitPrice = 620000, Quantity = 0, Brand_ID = "PN", Category_ID = "GBĐ", Picture_ID = 15 },
                new Product { Product_ID = "QCCLL", ProductName = "Quấn cán cầu lông Lining", UnitPrice = 20000, Quantity = 0, Brand_ID = "LN", Category_ID = "PK", Picture_ID = 18 },
                new Product { Product_ID = "QCCLY", ProductName = "Quấn cán cầu lông Yonex", UnitPrice = 50000, Quantity = 0, Brand_ID = "YNX", Category_ID = "PK", Picture_ID = 19 },
                new Product { Product_ID = "QCL", ProductName = "Ống cầu lông Lining", UnitPrice = 200000, Quantity = 0, Brand_ID = "LN", Category_ID = "PK", Picture_ID = 11 },
                new Product { Product_ID = "QCY", ProductName = "Ống cầu lông Yonex", UnitPrice = 1200000, Quantity = 0, Brand_ID = "YNX", Category_ID = "PK", Picture_ID = 12 },
                new Product { Product_ID = "Y65Z3WN39", ProductName = "Yonex SHB 65 Z3 Woman Navy Size 39", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 28 },
                new Product { Product_ID = "Y65Z3WN40", ProductName = "Yonex SHB 65 Z3 Woman Navy Size 40", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 28 },
                new Product { Product_ID = "Y65Z3WN41", ProductName = "Yonex SHB 65 Z3 Woman Navy Size 41", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 28 },
                new Product { Product_ID = "Y65Z3WN42", ProductName = "Yonex SHB 65 Z3 Woman Navy Size 42", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 28 },
                new Product { Product_ID = "Y65Z3WT39", ProductName = "Yonex SHB 65 Z3 White Tiger Size 39", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 27 },
                new Product { Product_ID = "Y65Z3WT40", ProductName = "Yonex SHB 65 Z3 White Tiger Size 40", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 27 },
                new Product { Product_ID = "Y65Z3WT41", ProductName = "Yonex SHB 65 Z3 White Tiger Size 41", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 27 },
                new Product { Product_ID = "Y65Z3WT42", ProductName = "Yonex SHB 65 Z3 White Tiger Size 42", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 27 },
                new Product { Product_ID = "Y65Z3WT43", ProductName = "Yonex SHB 65 Z3 White Tiger Size 43", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 27 },
                new Product { Product_ID = "Y65Z3WT44", ProductName = "Yonex SHB 65 Z3 White Tiger Size 44", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 27 },
                new Product { Product_ID = "YEZ3NAVY39", ProductName = "Yonex Eclipsion Z3 Men Navy Size 39", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 26 },
                new Product { Product_ID = "YEZ3NAVY40", ProductName = "Yonex Eclipsion Z3 Men Navy Size 40", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 26 },
                new Product { Product_ID = "YEZ3NAVY41", ProductName = "Yonex Eclipsion Z3 Men Navy Size 41", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 26 },
                new Product { Product_ID = "YEZ3NAVY42", ProductName = "Yonex Eclipsion Z3 Men Navy Size 42", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 26 },
                new Product { Product_ID = "YEZ3NAVY43", ProductName = "Yonex Eclipsion Z3 Men Navy Size 43", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 26 },
                new Product { Product_ID = "YEZ3NAVY44", ProductName = "Yonex Eclipsion Z3 Men Navy Size 44", UnitPrice = 2700000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 26 },
                new Product { Product_ID = "YEZ3WHITE39", ProductName = "Yonex Eclipsion Z3 Woman White Size 39", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 33 },
                new Product { Product_ID = "YEZ3WHITE40", ProductName = "Yonex Eclipsion Z3 Woman White Size 40", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 33 },
                new Product { Product_ID = "YEZ3WHITE41", ProductName = "Yonex Eclipsion Z3 Woman White Size 41", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 33 },
                new Product { Product_ID = "YEZ3WHITE42", ProductName = "Yonex Eclipsion Z3 Woman White Size 42", UnitPrice = 2600000, Quantity = 0, Brand_ID = "YNX", Category_ID = "GCL", Picture_ID = 33 },
                new Product { Product_ID = "QCLYN955DS", ProductName = "Quần Cầu Lông Yonex 955 Trắng Size S", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 34 },
                new Product { Product_ID = "QCLYN955DM", ProductName = "Quần Cầu Lông Yonex 955 Trắng Size M", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 34 },
                new Product { Product_ID = "QCLYN955DL", ProductName = "Quần Cầu Lông Yonex 955 Trắng Size L", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 34 },
                new Product { Product_ID = "QCLYN955DXL", ProductName = "Quần Cầu Lông Yonex 955 Trắng Size XL", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 34 },
                new Product { Product_ID = "QCLYN955TS", ProductName = "Quần Cầu Lông Yonex 955 Đen Size S", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 35 },
                new Product { Product_ID = "QCLYN955TM", ProductName = "Quần Cầu Lông Yonex 955 Đen Size M", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 35 },
                new Product { Product_ID = "QCLYN955TL", ProductName = "Quần Cầu Lông Yonex 955 Đen Size L", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 35 },
                new Product { Product_ID = "QCLYN955TXL", ProductName = "Quần Cầu Lông Yonex 955 Đen Size XL", UnitPrice = 130000, Quantity = 0, Brand_ID = "YNX", Category_ID = "QCL", Picture_ID = 35 }
            };
            context.Products.AddOrUpdate(p => p.Product_ID, products);

            var admin = new Employee
            {
                Employee_ID = "Admin",
                NameEmployee = "Bảo đẹp trai",
                Birthday = new DateTime(2004, 02, 17),
                Gender = "Nam",
                AddressEmployee = "Lâm Đồng",
                PhoneNumber = "0363609039",
                RoleEmployee = "Người tạo ra phần mềm này",
                Active = "1",
                PassWordAccount = "baodeptrai"
            };
            context.Employees.AddOrUpdate(admin);

            var quanLy01 = new Employee
            {
                Employee_ID = "QL01",
                NameEmployee = "Lê Thanh Phong",
                Birthday = new DateTime(2004, 03, 09),
                Gender = "Nam",
                AddressEmployee = "Long An",
                PhoneNumber = "0815474739",
                RoleEmployee = "Quản lý",
                Active = "1",
                PassWordAccount = "baodeptrai"
            };
            context.Employees.AddOrUpdate(quanLy01);

            var banHang01 = new Employee
            {
                Employee_ID = "BH01",
                NameEmployee = "Võ Thị Mỹ Lợi",
                Birthday = new DateTime(2004, 04, 08),
                Gender = "Nữ",
                AddressEmployee = "Bình Định",
                PhoneNumber = "0372260578",
                RoleEmployee = "Bán hàng",
                Active = "1",
                PassWordAccount = "baodeptrai"
            };
            context.Employees.AddOrUpdate(banHang01);

            var banHang02 = new Employee
            {
                Employee_ID = "BH02",
                NameEmployee = "Lương Bảo Long",
                Birthday = new DateTime(2011, 02, 01),
                Gender = "Nam",
                AddressEmployee = "TP.HCM",
                PhoneNumber = "0938430411",
                RoleEmployee = "Bán hàng",
                Active = "1",
                PassWordAccount = "baodeptrai"
            };
            context.Employees.AddOrUpdate(banHang02);

            var suppliers = new[]
            {
                new Supplier { Supplier_ID = "ATS", CompanyName = "Anh Thắng Sport", PhoneNumber = "0981122234", AddressSupplier = "41 Đường C1, P13, Q. Tân Bình, TP Hồ Chí Minh", Email = "anhthangsport.com" },
                new Supplier { Supplier_ID = "VNB", CompanyName = "Vietnam Badminton", PhoneNumber = "0977508430", AddressSupplier = "20 Cao Bá Nhạ, Phường Nguyễn Cư Trinh, Quận 1, TPHCM", Email = "info@shopvnb.com" },
                new Supplier { Supplier_ID = "YNS", CompanyName = "Yonex Sunrise Vietnam", PhoneNumber = "0363609038", AddressSupplier = "157 Điện Biên Phủ, Phường Đa Kao, Quận 1, Thành Phố Hồ Chí Minh, Việt Nam", Email = "sunrisevn@risesun.com.sg" }
            };
            context.Suppliers.AddOrUpdate(suppliers);

            var discounts = new[]
            {
                new Discount {DiscountCode = "14THANG2", PercentageDiscount = 15, StartDay = new DateTime(2024, 02, 10), EndDay = new DateTime(2024, 02, 15) },
                new Discount {DiscountCode = "30THANG4", PercentageDiscount = 25, StartDay = new DateTime(2024, 04, 25), EndDay = new DateTime(2024, 05, 03) },
                new Discount {DiscountCode = "8THANG3", PercentageDiscount = 20, StartDay = new DateTime(2024, 03, 05), EndDay = new DateTime(2024, 03, 10) }
            };
            context.Discounts.AddOrUpdate(discounts);

            var customers = new[]
            {
                new Customer { Customers_ID = "KH00001", PhoneNumber = "0901236767", NameCustomer = "Trần Đức Anh", Gender = "Nam", TotalMoney = 4050000 }
            };
            context.Customers.AddOrUpdate(customers);

            var imports = new[]
            {
                new Import { Import_ID = "NH00001", Supplier_ID = "VNB", ImportDay = new DateTime(2004, 02, 17), TotalMoney = 106000000 }
            };
            context.Imports.AddOrUpdate(imports);

            var importDetails = new[]
            {
                new ImportDetail { Import_ID = "NH00001", Product_ID = "88D2018", Quantity = 10, Unitcost = 6000000, TotalOfProduct = 60000000 },
                new ImportDetail { Import_ID = "NH00001", Product_ID = "99NAVY2020", Quantity = 10, Unitcost = 4500000, TotalOfProduct = 45000000 },
                new ImportDetail { Import_ID = "NH00001", Product_ID = "ACLYTXL", Quantity = 10, Unitcost = 100000, TotalOfProduct = 1000000 }
            };
            context.ImportDetails.AddOrUpdate(importDetails);

            var orders = new[]
            {
                new Order { Order_ID = "HD00001", Customers_ID = "KH00001", Employee_ID = "Admin", OrderDate = new DateTime(2024, 04, 30), TotalMoney = 4050000, DiscountCode = "30THANG4" }
            };
            context.Orders.AddOrUpdate(orders);

            var orderDetails = new[]
            {
                new OrderDetail { Order_ID = "HD00001", Product_ID = "99NAVY2020", Quantity = 1 },
                new OrderDetail { Order_ID = "HD00001", Product_ID = "ACLYTXL", Quantity = 2 }
            };
            context.OrderDetails.AddOrUpdate(orderDetails);

            context.SaveChanges();
        }
    }
}
