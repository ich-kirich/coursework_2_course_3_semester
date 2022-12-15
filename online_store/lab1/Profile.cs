using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {
            if (TextBoxAddBalance.Text != "")
            {
                int balance = Convert.ToInt32(labelBalance.Text);
                if (StringIsDigits(TextBoxAddBalance.Text) && TextBoxAddBalance.Text.Length <= 5)
                {
                    balance += Convert.ToInt32(TextBoxAddBalance.Text);
                }
                else if (TextBoxAddBalance.Text.Length > 5)
                {
                    MessageBox.Show(
                       "Нельзя пополнить баланс за одну операцию более чем на 10000 р.",
                       "Ошибка пополнения баланса!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.None,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly
                   );
                }
                labelBalance.Text = balance.ToString();
                TextBoxAddBalance.Clear();
                string[] usersBalance = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt");
                string[] currentUser = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
                for (int i = 0; i < usersBalance.Length; i++)
                {
                    string[] line = usersBalance[i].Split(' ');
                    if (line[0] == currentUser[0])
                    {
                        string toSaveBalance = currentUser[0] + " " + balance;
                        string str = string.Empty;
                        using (StreamReader reader = File.OpenText(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt"))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(usersBalance[i], toSaveBalance);

                        using (StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt"))
                        {
                            file.Write(str);
                        }
                        break;
                    }
                }
            }
        }
        private bool StringIsDigits(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            return true;
        }

        private void buttonToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
            while (!f.EndOfStream)
            {
                labelLoginUser.Text = f.ReadLine();
            }
            f.Close();
            string[] usersBalance = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\usersBalance.txt");
            string[] currentUser = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
            for (int i = 0; i < usersBalance.Length; i++)
            {
                string[] line = usersBalance[i].Split(' ');
                if (line[0] == currentUser[0])
                {
                    labelBalance.Text = line[1];
                }
            }
        }

        private void buttonToBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage toMain = new MainPage();
            toMain.Show();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void userOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            userOrders userOrdersForm = new userOrders();
            userOrdersForm.Show();
        }
    }
}
