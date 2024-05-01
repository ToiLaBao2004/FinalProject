using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.LoadDataFunc
{
    public class DataBienLai
    {
        public List<dynamic> LoadBienLai()
        {
            using (var dataContext = new DataContext())
            {
                var imports = from i in dataContext.Imports
                              select new
                              {
                                  i.Import_ID,
                                  i.Supplier_ID,
                                  i.ImportDay,
                                  i.TotalMoney
                              };

                return imports.ToList<dynamic>();
            }
        }

        public List<dynamic> TimBienLaiDuaTrenMaBienLai(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var imports = from i in dataContext.Imports
                              where i.Import_ID.Contains(keyword)
                              select new
                              {
                                  i.Import_ID,
                                  i.Supplier_ID,
                                  i.ImportDay,
                                  i.TotalMoney
                              };

                return imports.ToList<dynamic>();
            }
        }

        public List<dynamic> TimBienLaiDuaTrenMaNCC(string keyword)
        {
            using (var dataContext = new DataContext())
            {
                var imports = from i in dataContext.Imports
                              where i.Supplier_ID.Contains(keyword)
                              select new
                              {
                                  i.Import_ID,
                                  i.Supplier_ID,
                                  i.ImportDay,
                                  i.TotalMoney
                              };

                return imports.ToList<dynamic>();
            }
        }
    }
}
