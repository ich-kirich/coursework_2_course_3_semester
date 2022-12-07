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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] usersOrders = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt");
            for(int i = 0; i < usersOrders.Length; i++)
            {
                usersOrders[i] = usersOrders[i].Remove(usersOrders[i].Length - 1, 1);
                string[] userOder = usersOrders[i].Split('/');
                string userName = userOder[0];
                int priceOrder = 0;
                for (int j = 1; j < userOder.Length; j++)
                {
                    string[] order = userOder[j].Split('_');
                    priceOrder += Convert.ToInt32(order[1]);
                }
                string[] row = { userName, priceOrder.ToString()};
                var listViewItem = new ListViewItem(row);
                tableOfOrders.Items.Add(listViewItem);
            }
        }


        private void assignOrder_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
