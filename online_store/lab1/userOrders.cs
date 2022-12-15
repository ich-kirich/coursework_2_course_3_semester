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
    public partial class userOrders : Form
    {
        public userOrders()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void userOrders_Load(object sender, EventArgs e)
        {
            string[] usersOrders = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt");
            string[] currentUser = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
            for (int i = 0; i < usersOrders.Length; i++)
            {
                usersOrders[i] = usersOrders[i].Remove(usersOrders[i].Length - 1, 1);
                string[] userOder = usersOrders[i].Split('/');
                if (userOder[1] == currentUser[0])
                {
                    string idOrder = userOder[0];
                    string userName = userOder[1];
                    string status = userOder[3];
                    int priceOrder = 0;
                    for (int j = 4; j < userOder.Length; j++)
                    {
                        string[] order = userOder[j].Split('_');
                        priceOrder += Convert.ToInt32(order[1]);
                    }
                    string[] row = { idOrder, userName, priceOrder.ToString(), status };
                    var listViewItem = new ListViewItem(row);
                    userOrdersList.Items.Add(listViewItem);
                }
            }
        }

        private void toProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile ProfileForm = new Profile();
            ProfileForm.Show();
        }
    }
}
