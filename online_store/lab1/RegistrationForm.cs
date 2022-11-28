using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class RegistrationForm : Form
    {
        private User user = new User();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void toLogin_Click(object sender, EventArgs e)
        {
            bool isPass = true, isLog = true;
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (passField_reg.Text.Length <= 5 || !passField_reg.Text.All(char.IsLower) || hasSymbols.IsMatch(passField_reg.Text) || (passField_reg.Text.IndexOf(' ') >= 0))
            {
                error.Text = "Некорректные символы для пароля, пароль должен быть больше 5 символов в нижнем регистре и не содержать специальных символов";
                isPass = false;
            }
            if (loginField_reg.Text.Length <= 5 || !loginField_reg.Text.All(char.IsLower) || hasSymbols.IsMatch(loginField_reg.Text) || (loginField_reg.Text.IndexOf(' ') >= 0))
            {
                error.Text = "Некорректные символы для логина, логин должен быть больше 5 символов в нижнем регистре и не содержать специальных символов";
                isLog = false;
            }
            if (isLog && isPass)
            {
                user.setUserLogin(loginField_reg.Text);
                user.setUserPass(passField_reg.Text);
                string loginIser = user.getUserLogin();
                string passwordUser = user.getUserPass();
                string path = Directory.GetCurrentDirectory() + @"\files\users.txt";
                if (File.Exists(path))
                {
                    string text = "\n" + loginIser + " " + passwordUser + "\n";
                    File.AppendAllText(path, text);
                }
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
