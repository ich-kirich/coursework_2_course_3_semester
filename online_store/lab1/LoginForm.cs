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
            string inputLogin = loginField.Text;
            string inputPassword = passField.Text;
            StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\users.txt");
            if (inputLogin == "admin" && inputPassword == "admin")
            {
                addToLocalStorage(inputLogin);
                this.Hide();
                adminPanel to_adminPanel = new adminPanel();
                to_adminPanel.Show();
            }
            else
            {
                while (!f.EndOfStream)
                {
                    string lineFile = f.ReadLine();
                    string[] lineFileArray = lineFile.Split(' ');
                    if (lineFileArray[0] == inputLogin && lineFileArray[1] == inputPassword)
                    {
                        addToLocalStorage(inputLogin);
                        this.Hide();
                        Profile to_profile = new Profile();
                        to_profile.Show();
                    }
                }
                MessageBox.Show(
                    "Неверный логин или пароль",
                    "Неверный логин или пароль",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
                f.Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
        private void addToLocalStorage(string inputLogin)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\localStorage.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
                File.AppendAllText(path, inputLogin);
            }
        }
    }
}
