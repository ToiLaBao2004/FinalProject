using BusinessLogicLayer.LoadDataFunc;
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
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                DataNhaCungCap dataNhaCungCap = new DataNhaCungCap();
                dataGridViewNhaCungCap.DataSource = dataNhaCungCap.LoadNhaCungCap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBoxTimMaNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataNhaCungCap dataNhaCungCap = new DataNhaCungCap();
                dataGridViewNhaCungCap.DataSource = dataNhaCungCap.LoadNhaCungCapTheoMaNhaCungCap(textBoxTimMaNhaCungCap.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxTimSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataNhaCungCap dataNhaCungCap = new DataNhaCungCap();
                dataGridViewNhaCungCap.DataSource = dataNhaCungCap.LoadNhaCungCapTheoSoDienThoai(textBoxTimSoDienThoai.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewNhaCungCap.CurrentCell.RowIndex;

            textBoxHienThiMaNCC.Text = dataGridViewNhaCungCap.Rows[r].Cells[0].Value.ToString();
            textBoxHienThiTenNCC.Text = dataGridViewNhaCungCap.Rows[r].Cells[1].Value.ToString();
            textBoxSDT.Text = dataGridViewNhaCungCap.Rows[r].Cells[2].Value.ToString();
            textBoxDiaChi.Text = dataGridViewNhaCungCap.Rows[r].Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewNhaCungCap.Rows[r].Cells[4].Value.ToString();
        }
    }
}
