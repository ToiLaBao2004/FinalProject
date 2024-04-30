using BusinessLogicLayer.LoadDataFunc;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControl
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        void loadData()
        {
            DataSanPham dataSanPham = new DataSanPham();
            dataGridViewSanPham.DataSource = dataSanPham.loadSanPham();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
