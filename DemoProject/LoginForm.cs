using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string admin = "admin";
            string pass = "1234";
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (userName == admin && pass == password)
                {
                    MessageBox.Show("Giriş Başarılı Ana Ekrana Yönlendirileceksiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormProduct product = new FormProduct();
                    this.Visible = false;

                    product.Show();
                }
                else
                {
                    txtPassword.Text = "";
                    txtUserName.Text = string.Empty;
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"{txtUserName.Text}");
        }
    }
}
