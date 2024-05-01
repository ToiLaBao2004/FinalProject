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
    public partial class FormHoaDonBanHang : Form
    {
        public FormHoaDonBanHang()
        {
            InitializeComponent();
        }

        public void LoadHoaDon()
        {
            try
            {
                DataHoaDon dataHoaDon = new DataHoaDon();
                dataGridViewHoaDon.DataSource = dataHoaDon.LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHoaDonBanHang_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewHoaDon.CurrentCell.RowIndex;

            textBoxHienThiMaHoaDon.Text = dataGridViewHoaDon.Rows[r].Cells[0].Value.ToString();
            textBoxMaKhachHang.Text = dataGridViewHoaDon.Rows[r].Cells[1].Value.ToString();
            textBoxMaNhanVien.Text = dataGridViewHoaDon.Rows[r].Cells[2].Value.ToString();
            dateTimePickerNTT.Text = dataGridViewHoaDon.Rows[r].Cells[3].Value.ToString();
            textBoxMKM.Text = dataGridViewHoaDon.Rows[r].Cells[5].Value.ToString();
            textBoxTongTien.Text = dataGridViewHoaDon.Rows[r].Cells[4].Value.ToString();

            dateTimePickerTimNTT.Text = dataGridViewHoaDon.Rows[r].Cells[3].Value.ToString();
        }

        private void textBoxTimMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataHoaDon dataHoaDon = new DataHoaDon();
                dataGridViewHoaDon.DataSource = dataHoaDon.TimHoaDonLoadVaoDGV(textBoxTimMaHoaDon.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerTimNTT_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePickerTimNTT.Value.Date;

                DataHoaDon dataHoaDon = new DataHoaDon();
                dataGridViewHoaDon.DataSource = dataHoaDon.TimHoaDonTheoNgayLoadVaoDGV(selectedDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
