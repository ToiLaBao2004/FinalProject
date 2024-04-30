using BusinessLogicLayer.LoadDataFunc;
using DataAccessLayer.Context;
using PresentationLayer.DetailForm;
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
        string Product_ID;
        public FormSanPham()
        {
            InitializeComponent();
        }

        void loadData()
        {
            DataSanPham dataSanPham = new DataSanPham();
            dataGridViewSanPham.DataSource = dataSanPham.LoadSanPham();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewSanPham.CurrentCell.RowIndex;

            Product_ID = dataGridViewSanPham.Rows[r].Cells[0].Value.ToString();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int r = dataGridViewSanPham.Rows.Count;
            if (r > 1)
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(1, Product_ID);
                productDetailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int r = dataGridViewSanPham.Rows.Count;
            if (r > 1)
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(1, Product_ID);
                productDetailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }
    }
}
