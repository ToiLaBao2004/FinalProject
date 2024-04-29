using BusinessLogicLayer.LoginFunc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBoxConMat_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar != '\0')
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            DangNhapFunction dangNhapFunction = new DangNhapFunction();
            bool check = dangNhapFunction.DangNhap(textBoxUsername.Text, textBoxPassword.Text);
            if (check)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }
    }
}
