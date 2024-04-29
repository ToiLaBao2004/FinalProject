using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            try
            {
                DataContext context = new DataContext();
                Customer customer = new Customer();
                customer.Customers_ID = "hahavc";
                customer.PhoneNumber = "0363609";
                customer.NameCustomer = "hehe";
                customer.Gender = "Nam";
                context.Customers.Add(customer);
                context.SaveChanges();
                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
