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
            int balance = Convert.ToInt32(labelBalance.Text);
            if (StringIsDigits(TextBoxAddBalance.Text))
            {
                balance += Convert.ToInt32(TextBoxAddBalance.Text);
            }
            labelBalance.Text = balance.ToString();
            TextBoxAddBalance.Clear();
        }
        public bool StringIsDigits(string s)
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
        }

        private void buttonToBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage toMain = new MainPage();
            toMain.Show();
        }
    }
}
