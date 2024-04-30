using System.Windows.Forms;
using PresentationLayer.UserControl;

namespace PresentationLayer.GUI
{
    public partial class MainForm : Form
    {
        FormSanPham formSanPham = new FormSanPham();
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
        }

        void turnOfAllForm()
        {
            formSanPham.Hide();
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
    }
}
