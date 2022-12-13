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
                string worker = userOder[1];
                string status = userOder[2];
                int priceOrder = 0;
                for (int j = 3; j < userOder.Length; j++)
                {
                    string[] order = userOder[j].Split('_');
                    priceOrder += Convert.ToInt32(order[1]);
                }
                string[] row = { userName, priceOrder.ToString(), worker, status };
                var listViewItem = new ListViewItem(row);
                tableOfOrders.Items.Add(listViewItem);
            }
            workersList.Items.AddRange(new string[] { "Боб", "Александр", "Андрей", "Роман" });
            statusOrder.Items.AddRange(new string[] { "В процессе рассмотрения", "Назначен работник", "В процессе выполнения", "Выполнен" });
        }


        private void assignOrder_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = tableOfOrders.CheckedItems;
            if (checkedItems.Count <= 0)
            {
                MessageBox.Show(
                    "Выберите заказ!",
                    "Выберите заказ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                string path = Directory.GetCurrentDirectory() + @"\files\orders.txt";
                string resultOrder = "";
                if (File.Exists(path))
                {
                    foreach (ListViewItem item in checkedItems)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            resultOrder += item.SubItems[i].Text + "/";
                        }
                        File.AppendAllText(path, resultOrder + "\n");
                        resultOrder = "";
                    }
                    MessageBox.Show(
                        "Заказ записан!",
                        "Заказ записан!",
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

        private void chooseWorker_Click(object sender, EventArgs e)
        {
            if (workersList.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Выберите работника!",
                    "Выберите работника",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                ListView.CheckedListViewItemCollection checkedItems = tableOfOrders.CheckedItems;
                if (checkedItems.Count <= 0)
                {
                    MessageBox.Show(
                        "Выберите заказ!",
                        "Выберите заказ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
                else
                {
                    foreach (ListViewItem item in checkedItems)
                    {
                        item.SubItems[2].Text = workersList.SelectedItem.ToString();
                    }
                }
            }
        }

        private void chooseStatus_Click(object sender, EventArgs e)
        {
            if (statusOrder.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Выберите статус заказа!",
                    "Выберите статус заказа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                ListView.CheckedListViewItemCollection checkedItems = tableOfOrders.CheckedItems;
                if (checkedItems.Count <= 0)
                {
                    MessageBox.Show(
                        "Выберите заказ!",
                        "Выберите заказ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
                else
                {
                    foreach (ListViewItem item in checkedItems)
                    {
                        item.SubItems[3].Text = statusOrder.SelectedItem.ToString();
                    }
                }
            }
        }
    }
}
