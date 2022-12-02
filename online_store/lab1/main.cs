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
        public MainPage()
        {
            InitializeComponent();
            listOfGoods.SelectedIndexChanged += listOfGoods_SelectedIndexChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void listOfGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
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
             Environment.Exit(1);
        }

        private void loginField_reg_TextChanged(object sender, EventArgs e)
        {

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
    }
}
