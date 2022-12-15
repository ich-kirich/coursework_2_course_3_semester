using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Products
    {
        private string pictureProduct;
        private string categoryProduct;
        private string nameProduct;
        private string[] typesProducts;
        private int price = 0;
        private List<string> productsBusket = new List<string>();

        public Products()
        {

        }

        public string[] getTypesProducts()
        {
            return typesProducts;
        }
        public string getPictureProduct()
        {
            return pictureProduct;
        }

        public string setCategoryProduct(string categoryProduct_inp)
        {
            return categoryProduct = categoryProduct_inp;
        }

        public string setNameProduct(string nameProduct_inp)
        {
            return nameProduct = nameProduct_inp;
        }

        public int getPrice()
        {
            return price;
        }

        public List<string> getProductsBusket()
        {
            return productsBusket;
        }

        public void selecteCategotyProduct()
        {
            string[] goods = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\goodsList.txt");
            for (int i = 0; i < goods.Length; i++)
            {
                string[] good = goods[i].Split('_');
                string[] goodCategory = good[0].Split('/');
                if (categoryProduct == goodCategory[0])
                {
                    pictureProduct = Directory.GetCurrentDirectory() + $@"\img\{good[1]}.jpg";
                    List<string> goodsTypes = new List<string>();
                    for (int j = 1; j < goodCategory.Length; j++)
                    {
                        goodsTypes.Add(goodCategory[j]);
                    }
                    string[] goodsTypesArr = goodsTypes.ToArray();
                    typesProducts = goodsTypesArr;
                }
            }
        } // выбор категории товара

        public void selectProduct()
        {
            for (int i = 0; i < typesProducts.Length; i++)
            {
                if (nameProduct == typesProducts[0])
                {
                    price = 100;
                }
                else if (nameProduct == typesProducts[1])
                {
                    price = 200;
                }
                else if (nameProduct == typesProducts[2])
                {
                    price = 300;
                }
            }
        } // выбор цены для товара

        public void addToBusket(int resultPrice)
        {
            const int defaultCountGood = 1;
            string addProduct = $"{nameProduct}_{resultPrice}р._{defaultCountGood}шт.";
            productsBusket.Add(addProduct);
        }

        public bool goodIsChoose()
        {
            for (int i = 0; i < productsBusket.Count; i++)
            {
                string[] good = productsBusket[i].Split('_');
                if (good[0] == nameProduct)
                {
                    return true;
                }
            }
            string[] goodsInBasket = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\files\basket.txt");
            for (int j = 0; j < goodsInBasket.Length; j++)
            {
                string[] goodInBasket = goodsInBasket[j].Split('_');
                if (goodInBasket[0] == nameProduct)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
