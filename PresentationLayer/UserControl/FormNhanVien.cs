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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                DataNhanVien dataNhanVien = new DataNhanVien();
                dataGridViewNhanVien.DataSource = dataNhanVien.LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewNhanVien.CurrentCell.RowIndex;

            textBoxHienThiMaNhanVien.Text = dataGridViewNhanVien.Rows[r].Cells[0].Value.ToString();
            textBoxHienThiTenNhanVien.Text = dataGridViewNhanVien.Rows[r].Cells[1].Value.ToString();
            textBoxGioiTinh.Text = dataGridViewNhanVien.Rows[r].Cells[3].Value.ToString();
            textBoxHienThiSoDienThoai.Text = dataGridViewNhanVien.Rows[r].Cells[4].Value.ToString();
            textBoxChucVu.Text = dataGridViewNhanVien.Rows[r].Cells[5].Value.ToString();
            if (dataGridViewNhanVien.Rows[r].Cells[6].Value.ToString() == "1")
            {
                textBoxTrangThai.Text = "Còn làm";
            }
            else
            {
                textBoxTrangThai.Text = "Đã nghỉ làm";
            }
        }

        private void textBoxTimMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataNhanVien dataNhanVien = new DataNhanVien();
                dataGridViewNhanVien.DataSource = dataNhanVien.TimNhanVienTheoMaNhanVienLoadVaoDGV(textBoxTimMaNhanVien.Text);
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
                DataNhanVien dataNhanVien = new DataNhanVien();
                dataGridViewNhanVien.DataSource = dataNhanVien.TimNhanVienTheoSoDienThoaiLoadVaoDGV(textBoxTimSoDienThoai.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
