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
            bool checkUser = user.validationRegistration(loginField_reg.Text, passField_reg.Text);
            if (!checkUser)
            {
                MessageBox.Show(
                    "Некорректные символы для пароля или логина," + "\r\n" + 
                    "пароль и логин должны быть больше 5 символов в нижнем регистре," + 
                    "\r\n" + "не содержать специальных символов" + "\r\n" + 
                    "и содержать хотя бы одну букву" + "\r\n" + 
                    "или аккаунт с таким логином уже существует",
                    "Ошибка регистрации аккаунта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                user.registrationNewUser(loginField_reg.Text, passField_reg.Text);
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void toLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
