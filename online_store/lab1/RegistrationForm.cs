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
            if (passField_reg.Text.Length < 5 || !isLow((passField_reg.Text)) || hasSymbols.IsMatch(passField_reg.Text) || (passField_reg.Text.IndexOf(' ') >= 0) || !Regex.IsMatch(passField_reg.Text, @"\p{L}"))
            {
                error.Text = "Некорректные символы для пароля, пароль должен быть больше 5 символов в нижнем регистре, не содержать специальных символов и содержать хотя бы одну букву";
                isPass = false;
            }
            if (loginField_reg.Text.Length < 5 || !isLow((loginField_reg.Text)) || hasSymbols.IsMatch(loginField_reg.Text) || (loginField_reg.Text.IndexOf(' ') >= 0) || !Regex.IsMatch(loginField_reg.Text, @"\p{L}"))
            {
                error.Text = "Некорректные символы для логина, логин должен быть больше 5 символов в нижнем регистре, не содержать специальных символов и содержать хотя бы одну букву";
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
                path = Directory.GetCurrentDirectory() + @"\files\usersBalance.txt";
                string toSaveBalance = loginIser + " " + 1000 + "\n";
                if (File.Exists(path))
                {
                    File.AppendAllText(path, toSaveBalance);
                }
                path = Directory.GetCurrentDirectory() + @"\files\usersWasted.txt";
                string toSaveWasted = loginIser + " " + 0 + " " + 0 + "\n";
                if (File.Exists(path))
                {
                    File.AppendAllText(path, toSaveWasted);
                }
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        protected bool isLow(string s)
        {
            bool isLow = true;
            for(int i = 0; i < s.Length; i++)
            {
                if (!Char.IsLower(s[i]) && !Char.IsDigit(s[i]))
                {
                    isLow = false;
                }
            }
            return isLow;
        }
    }
}
