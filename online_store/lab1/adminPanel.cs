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
                string idOrder = userOder[0];
                string userName = userOder[1];
                string worker = userOder[2];
                string status = userOder[3];
                int priceOrder = 0;
                for (int j = 4; j < userOder.Length; j++)
                {
                    string[] order = userOder[j].Split('_');
                    priceOrder += Convert.ToInt32(order[1]);
                }
                string[] row = { idOrder, userName, priceOrder.ToString(), worker, status };
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
                    "Ошибка записи заказа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                string path = Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt";
                string[] ordersList = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt");
                if (File.Exists(path))
                {
                    foreach (ListViewItem item in checkedItems)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = File.OpenText(path))
                        {
                            str = reader.ReadToEnd();
                        }
                        for (int i = 0; i < ordersList.Length; i++)
                        {
                            string[] order = ordersList[i].Split('/');
                            if (item.SubItems[0].Text == order[0])
                            {
                                string resultOrder = item.SubItems[0].Text + "/" + item.SubItems[1].Text + "/" + item.SubItems[3].Text + "/" 
                                    + item.SubItems[4].Text + "/";
                                for (int j = 4; j < order.Length; j++)
                                {
                                    resultOrder += order[j] + "/";
                                }
                                resultOrder = resultOrder.Remove(resultOrder.Length - 1, 1);
                                str = str.Replace(ordersList[i], resultOrder);
                            }
                        }
                        using (StreamWriter file = new StreamWriter(path))
                        {
                            file.Write(str);
                        }
                    }
                    MessageBox.Show(
                        "Заказ записан!",
                        "Запись успешно осуществлена",
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
                    "Ошибка назначения работника",
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
                        "Ошибка назначения работника",
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
                        item.SubItems[3].Text = workersList.SelectedItem.ToString();
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
                    "Ошибка изменения статуса",
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
                        "Ошибка изменения статуса",
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
                        item.SubItems[4].Text = statusOrder.SelectedItem.ToString();
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
