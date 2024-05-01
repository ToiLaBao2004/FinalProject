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
    public partial class FormBienLai : Form
    {
        public FormBienLai()
        {
            InitializeComponent();
        }

        public void LoadBienLai()
        {
            try
            {
                DataBienLai dataBienLai = new DataBienLai();
                dataGridViewBienLai.DataSource = dataBienLai.LoadBienLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBienLai_Load(object sender, EventArgs e)
        {
            LoadBienLai();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadBienLai();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadBienLai();
        }

        private void dataGridViewBienLai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewBienLai.CurrentCell.RowIndex;

            textBoxHienThiMaBienLai.Text = dataGridViewBienLai.Rows[r].Cells[0].Value.ToString();
            textBoxMaNhaCungCap.Text = dataGridViewBienLai.Rows[r].Cells[1].Value.ToString();
            dateTimePickerNN.Text = dataGridViewBienLai.Rows[r].Cells[2].Value.ToString();
            textBoxTongTien.Text = dataGridViewBienLai.Rows[r].Cells[3].Value.ToString();
        }

        private void textBoxTimMaBienLai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataBienLai dataBienLai = new DataBienLai();
                dataGridViewBienLai.DataSource = dataBienLai.TimBienLaiDuaTrenMaBienLai(textBoxTimMaBienLai.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxTimMaNhaCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataBienLai dataBienLai = new DataBienLai();
                dataGridViewBienLai.DataSource = dataBienLai.TimBienLaiDuaTrenMaNCC(textBoxTimMaNhaCC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
