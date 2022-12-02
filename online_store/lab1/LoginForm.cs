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
    public partial class LoginForm : Form
    {
        private User user = new User();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void toRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void toMain_Click(object sender, EventArgs e)
        {
            bool isAdmin = user.isAdmin(loginField.Text, passField.Text);
            if (isAdmin)
            {
                this.Hide();
                adminPanel to_adminPanel = new adminPanel();
                to_adminPanel.Show();
            }
            else
            {
                bool isLogIn = user.accountLogin(loginField.Text, passField.Text);
                if (isLogIn)
                {
                    this.Hide();
                    Profile to_profile = new Profile();
                    to_profile.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Неверный логин или пароль",
                        "Неверный логин или пароль",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
