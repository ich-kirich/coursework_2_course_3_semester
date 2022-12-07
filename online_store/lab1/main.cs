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
    public partial class MainPage : Form
    {
        private string selectedCategory;
        private Products product = new Products();
        private bool isCount = false, isGood = false;
        public MainPage()
        {
            InitializeComponent();
            listOfGoods.SelectedIndexChanged += listOfGoods_SelectedIndexChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void listOfGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            isGood = true;
            countProduct.Text = "";
            resultBuy.Text = "0";
            product.setNameProduct(listOfGoods.SelectedItem.ToString());
            product.selectProduct();
            priceGood.Text = product.getPrice().ToString();
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

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile toProfile = new Profile();
            toProfile.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
            }
            Environment.Exit(1);
        }

        private void chandeListGoods(string selectedCategory)
        {
            priceGood.Text = "0";
            countProduct.Text = "";
            resultBuy.Text = "0";
            listOfGoods.Items.Clear();
            product.setCategoryProduct(selectedCategory);
            product.selecteCategotyProduct();
            pictureGood.Image = Image.FromFile(product.getPictureProduct());
            listOfGoods.Items.AddRange(product.getTypesProducts());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCount = false;
            isGood = false;
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                selectedCategory = listView1.Items[intselectedindex].Text;
                chandeListGoods(selectedCategory);
            }
        }

        private void calculatePrice_Click(object sender, EventArgs e)
        {
            if (countProduct.Text.All(char.IsDigit) && countProduct.Text != "")
            {
                if (Convert.ToInt32(countProduct.Text) > 100)
                {
                    MessageBox.Show(
                        "Нельзя купить товаров одного типа более чем на 100 штук",
                        "Ограничение на кол-во покупаемого товара",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
                else
                {
                    int resultPrice = product.resultPrice(Convert.ToInt32(countProduct.Text));
                    resultBuy.Text = resultPrice.ToString();
                    isCount = true;
                }
            }
            else
            {
                MessageBox.Show(
                    "Введите целое число",
                    "Ошибка ввода!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void addBusket_Click(object sender, EventArgs e)
        {
            if (!isCount || Convert.ToInt32(resultBuy.Text) == 0 || !isGood)
            {
                MessageBox.Show(
                   "Посчитайте стоимость покупки и выберите продукт",
                   "Посчитайте стоимость покупки и выберите продукт!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.None,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly
               );
            }
            else
            {
                product.addToBusket(Convert.ToInt32(resultBuy.Text));
                MessageBox.Show(
                    "Продукт добавлен в корзину",
                    "Продукт добавлен в корзину!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void basket_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                for (int j = 0; j < product.getProductsBusket().Count; j++)
                {
                    File.AppendAllText(path, product.getProductsBusket()[j] + "\n");
                }
            }
            this.Hide();
            ordersForm toBusket = new ordersForm();
            toBusket.Show();
        }
    }
}
