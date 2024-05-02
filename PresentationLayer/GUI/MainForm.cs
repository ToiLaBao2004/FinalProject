using System.Windows.Forms;
using PresentationLayer.UserControl;

namespace PresentationLayer.GUI
{
    public partial class MainForm : Form
    {
        FormSanPham formSanPham = new FormSanPham();
        FormHoaDonBanHang formHoaDonBanHang = new FormHoaDonBanHang();
        FormKhachHang formKhachHang = new FormKhachHang();
        FormBienLai formBienLai = new FormBienLai();
        FormNhanVien formNhanVien = new FormNhanVien();
        FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
        public MainForm(string name, string chucVu)
        {
            InitializeComponent();
            this.labelName.Text = name;
            this.labelChucVu.Text = chucVu;
            addForm();
            formSanPham.Show();
        }

        void addForm()
        {
            formSanPham.TopLevel = false;
            panel.Controls.Add(formSanPham);

            formHoaDonBanHang.TopLevel = false;
            panel.Controls.Add(formHoaDonBanHang);

            formKhachHang.TopLevel = false;
            panel.Controls.Add(formKhachHang);

            formBienLai.TopLevel = false;
            panel.Controls.Add(formBienLai);

            formNhanVien.TopLevel = false;
            panel.Controls.Add(formNhanVien);

            formNhaCungCap.TopLevel = false;
            panel.Controls.Add(formNhaCungCap);
        }

        void turnOfAllForm()
        {
            formSanPham.Hide();
            formHoaDonBanHang.Hide();
            formKhachHang.Hide();
            formBienLai.Hide();
            formNhanVien.Hide();
            formNhaCungCap.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonDangXuat_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void buttonSanPham_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formSanPham.Show();
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formSanPham.Show();
        }

        private void buttonHoaDon_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formHoaDonBanHang.Show();
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formHoaDonBanHang.Show();
        }

        private void buttonKhachHang_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formKhachHang.Show();
        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formKhachHang.Show();
        }

        private void pictureBox9_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void buttonHoaDonNhap_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formBienLai.Show();
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formBienLai.Show();
        }

        private void buttonNhanVien_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formNhanVien.Show();
        }

        private void pictureBox7_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formNhanVien.Show();
        }

        private void buttonNhaCungCap_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formNhaCungCap.Show();
        }

        private void pictureBox8_Click(object sender, System.EventArgs e)
        {
            turnOfAllForm();
            formNhaCungCap.Show();
        }
    }
}
