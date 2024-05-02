using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataNhaCungCap
    {
        public List<dynamic> LoadNhaCungCap()
        {
            using (var dataContext = new DataContext())
            {
                var suppliers = from s in dataContext.Suppliers
                                select new
                                {
                                    s.Supplier_ID,
                                    s.CompanyName,
                                    s.PhoneNumber,
                                    s.AddressSupplier,
                                    s.Email
                                };

                return suppliers.ToList<dynamic>();
            }
        }

        public List<dynamic> LoadNhaCungCapTheoMaNhaCungCap(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var suppliers = from s in dataContext.Suppliers
                                where s.Supplier_ID.Contains(keyword)
                                select new
                                {
                                    s.Supplier_ID,
                                    s.CompanyName,
                                    s.PhoneNumber,
                                    s.AddressSupplier,
                                    s.Email
                                };

                return suppliers.ToList<dynamic>();
            }
        }

        public List<dynamic> LoadNhaCungCapTheoSoDienThoai(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var suppliers = from s in dataContext.Suppliers
                                where s.PhoneNumber.Contains(keyword)
                                select new
                                {
                                    s.Supplier_ID,
                                    s.CompanyName,
                                    s.PhoneNumber,
                                    s.AddressSupplier,
                                    s.Email
                                };

                return suppliers.ToList<dynamic>();
            }
        }
    }
}
