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
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
            }
            Environment.Exit(1);
        }

        private void toMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage toMain = new MainPage();
            toMain.Show();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            string[] basketGoods = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\basket.txt");
            for (int i = 0; i < basketGoods.Length; i++)
            {
                string[] goods = basketGoods[i].Split('_');
                string userName = goods[0];
                string sum = goods[1];
                string count = goods[2];
                string[] row = { userName, sum, count };
                var listViewItem = new ListViewItem(row);
                basketList.Items.Add(listViewItem);
            }
            updatePrice();
        }

        private void order_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection selectedGoods = basketList.CheckedItems;
            if (selectedGoods.Count <= 0)
            {
                MessageBox.Show(
                    "Выберите товары, которые хотите заказать!",
                    "Выберите товары",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                StreamReader f = new StreamReader(Directory.GetCurrentDirectory() + @"\files\localStorage.txt");
                string user = "";
                while (!f.EndOfStream)
                {
                    user = f.ReadLine();
                }
                f.Close();
                string path = Directory.GetCurrentDirectory() + @"\files\ordersInProgress.txt";
                string goods = "";
                string worker = "Не назначен";
                string statusOrder = "В процессе рассмотрения";
                if (File.Exists(path))
                {
                    File.AppendAllText(path, user + "/" + worker + "/" + statusOrder + "/");
                    foreach (ListViewItem item in selectedGoods)
                    {
                        string res = item.SubItems[0].Text + "_" + Convert.ToInt32(item.SubItems[1].Text.Replace("р.", "")) * Convert.ToInt32(item.SubItems[2].Text.Replace("шт.", ""));
                        goods += res + "/";
                    }
                    File.AppendAllText(path, goods + "\n");
                }
                MessageBox.Show(
                    "Заказ сделан",
                    "Заказ сделан!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void upgateCountGood_Click(object sender, EventArgs e)
        {
            if (inputCountGood.Text.All(char.IsDigit) && inputCountGood.Text != "")
            {
                if (Convert.ToInt32(inputCountGood.Text) > 0)
                {
                    ListView.CheckedListViewItemCollection checkedItems = basketList.CheckedItems;
                    if (checkedItems.Count <= 0)
                    {
                        MessageBox.Show(
                            "Выберите товар!",
                            "Выберите товар",
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
                            item.SubItems[2].Text = inputCountGood.Text + "шт.";
                        }
                        updatePrice();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Введите число, большее нуля",
                        "Введите число, большее нуля",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Введите целое число",
                    "Введите целое число",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void updatePrice()
        {
            int price = 0;
            foreach (ListViewItem item in basketList.Items)
            {
                price += Convert.ToInt32(item.SubItems[1].Text.Replace("р.", "")) * Convert.ToInt32(item.SubItems[2].Text.Replace("шт.", ""));
            }
            resultPrice.Text = "Итоговая цена: " + price.ToString() + "р.";
        }
    }
}
