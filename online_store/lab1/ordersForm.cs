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
                basketGoods[i] = basketGoods[i].Replace("_", "  ") + " р.";
            }
            basketList.Items.AddRange(basketGoods);
        }

        private void order_Click(object sender, EventArgs e)
        {
            List<object> selectedGoods = basketList.CheckedItems.OfType<object>().ToList();
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
                if (File.Exists(path))
                {
                    File.AppendAllText(path, user + " ");
                    for (int j = 0; j < selectedGoods.Count; j++)
                    {
                        selectedGoods[j] = selectedGoods[j].ToString().Replace("  ", "_").Replace(" р.", "");
                        File.AppendAllText(path, selectedGoods[j] + " ");
                    }
                    File.AppendAllText(path, "\n");
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
    }
}
