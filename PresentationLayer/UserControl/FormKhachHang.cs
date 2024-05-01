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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        public void LoadKhachHang()
        {
            try
            {
                DataKhachHang dataKhachHang = new DataKhachHang();
                dataGridViewKhachHang.DataSource = dataKhachHang.LoadKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewKhachHang.CurrentCell.RowIndex;

            textBoxHienThiMaKhachHang.Text = dataGridViewKhachHang.Rows[r].Cells[0].Value.ToString();
            textBoxHienThiSoDienThoai.Text = dataGridViewKhachHang.Rows[r].Cells[1].Value.ToString();
            textBoxTenKhachHang.Text = dataGridViewKhachHang.Rows[r].Cells[2].Value.ToString();
            textBoxGioiTinh.Text = dataGridViewKhachHang.Rows[r].Cells[4].Value.ToString();
            if (dataGridViewKhachHang.Rows[r].Cells[5].Value != null)
            {
                textBoxDiaChi.Text = dataGridViewKhachHang.Rows[r].Cells[5].Value.ToString();
            }
            else
            {
                textBoxDiaChi.Text = "";
            }
            textBoxTongTienDaMua.Text = dataGridViewKhachHang.Rows[r].Cells[6].Value.ToString();
        }

        private void textBoxTimMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataKhachHang dataKhachHang = new DataKhachHang();
                dataGridViewKhachHang.DataSource = dataKhachHang.TimKhachHangTheoMaKhachHangLoadVaoDGV(textBoxTimMaKhachHang.Text);
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
                DataKhachHang dataKhachHang = new DataKhachHang();
                dataGridViewKhachHang.DataSource = dataKhachHang.TimKhachHangTheoSDTLoadVaoDGV(textBoxTimSoDienThoai.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
