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
            try
            {
                DataSanPham dataSanPham = new DataSanPham();
                dataGridViewSanPham.DataSource = dataSanPham.LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                int r = dataGridViewSanPham.CurrentCell.RowIndex;
                Product_ID = dataGridViewSanPham.Rows[r].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing cell click: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(1, Product_ID);
                productDetailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(1, Product_ID);
                productDetailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAoCauLong_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("ACL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuanCauLong_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("QCL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVotCauLong_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("VCL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGiayCauLong_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("GCL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBoDoBongDa_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("BĐBĐ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGiayDaBong_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("GBĐ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPhuKien_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("PK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("ACL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("QCL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("VCL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("GCL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("BĐBĐ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("GBĐ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                dataGridViewSanPham.DataSource = dataPhanLoaiSP.LoadSanPhamTheoLoai("PK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataSanPham dataSanPham = new DataSanPham();
            try
            {
                int r = dataGridViewSanPham.CurrentCell.RowIndex;
                Product_ID = dataGridViewSanPham.Rows[r].Cells[0].Value.ToString();

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataSanPham.XoaSanPham(Product_ID);
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã huỷ xóa sản phẩm");
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataSanPham dataSanPham = new DataSanPham();
            try
            {
                int r = dataGridViewSanPham.CurrentCell.RowIndex;
                Product_ID = dataGridViewSanPham.Rows[r].Cells[0].Value.ToString();

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataSanPham.XoaSanPham(Product_ID);
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã huỷ xóa sản phẩm");
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(2, Product_ID);
                productDetailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(2, Product_ID);
                productDetailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(3, Product_ID);
                productDetailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetailForm productDetailForm = new ProductDetailForm(3, Product_ID);
                productDetailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSanPham dataSanPham = new DataSanPham();
                dataGridViewSanPham.DataSource = dataSanPham.TimSanPhamLoadVaoDGV(textBoxSanPham.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxThuongHieu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataThuongHieu dataThuongHieu = new DataThuongHieu();
                dataGridViewSanPham.DataSource = dataThuongHieu.TimSanPhamLoadVaoDGV(textBoxThuongHieu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
