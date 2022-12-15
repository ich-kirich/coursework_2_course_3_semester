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
        private bool isGood = false;
        public MainPage()
        {
            InitializeComponent();
            listOfGoods.SelectedIndexChanged += listOfGoods_SelectedIndexChanged;
            listGoods.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void listOfGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            isGood = true;
            product.setNameProduct(listOfGoods.SelectedItem.ToString());
            product.selectProduct();
            priceGood.Text = product.getPrice().ToString();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
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
            Environment.Exit(1);
        }

        private void chandeListGoods(string selectedCategory)
        {
            priceGood.Text = "0";
            listOfGoods.Items.Clear();
            product.setCategoryProduct(selectedCategory);
            product.selecteCategotyProduct();
            pictureGood.Image = Image.FromFile(product.getPictureProduct());
            listOfGoods.Items.AddRange(product.getTypesProducts());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isGood = false;
            if (listGoods.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listGoods.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                selectedCategory = listGoods.Items[intselectedindex].Text;
                chandeListGoods(selectedCategory);
            }
        }

        private void addBusket_Click(object sender, EventArgs e)
        {
            if (!isGood)
            {
                MessageBox.Show(
                   "Выберите продукт!",
                   "Ошибка добавления продукта в корзину",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.None,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly
               );
            }
            else
            {
                if (!product.goodIsChoose())
                {
                    product.addToBusket(Convert.ToInt32(priceGood.Text));
                    MessageBox.Show(
                        "Продукт добавлен в корзину!",
                        "Продукт успешно добавлен в корзину",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
                else
                {
                    MessageBox.Show(
                       "Продукт уже добавлен в корзину!",
                       "Ошибка добавления продукта в корзину",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.None,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly
                   );
                }
            }
        }

        private void basket_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\files\basket.txt";
            if (File.Exists(path))
            {
                for (int j = 0; j < product.getProductsBusket().Count; j++)
                {
                    File.AppendAllText(path, "\n" + product.getProductsBusket()[j]);
                }
            }
            this.Hide();
            ordersForm toBusket = new ordersForm();
            toBusket.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            addCategoryGood();
        }

        private void addCategoryGood()
        {
            string[] goods = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\goodsList.txt");
            for (int i = 0; i < goods.Length; i++)
            {
                string[] good = goods[i].Split('/');
                string[] row = { good[0] };
                var listViewItem = new ListViewItem(row);
                listGoods.Items.Add(listViewItem);
            }
        }
    }
}
