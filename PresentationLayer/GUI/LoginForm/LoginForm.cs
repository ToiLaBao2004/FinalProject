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
            if (textBoxPassWord.PasswordChar != '\0')
                textBoxPassWord.PasswordChar = '\0';
            else
                textBoxPassWord.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxPassWord.Focus();
            }
        }

        private void textBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, null);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DangNhapFunction dangNhapFunction = new DangNhapFunction();
            bool check = dangNhapFunction.DangNhap(textBoxUsername.Text, textBoxPassWord.Text);

            if (check)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                //
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
                textBoxUsername.Clear();
                textBoxPassWord.Clear();
                textBoxUsername.Focus();
            }
        }
    }
}
