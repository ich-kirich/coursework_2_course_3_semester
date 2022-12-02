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
        private string[] typesProducts;

        public Products()
        {

        } // инициализация списка покупок

        public string[] setTypesProducts(string[] typesProducts_inp)
        {
            return typesProducts = typesProducts_inp;
        }

        public string[] getTypesProducts()
        {
            return typesProducts;
        }

        public string setPictureProduct(string pictureProduct_inp)
        {
            return pictureProduct = pictureProduct_inp;
        }
        public string getPictureProduct()
        {
            return pictureProduct;
        }

        public string setCategoryProduct(string categoryProduct_inp)
        {
            return categoryProduct = categoryProduct_inp;
        }
        public string getCategoryProduct()
        {
            return categoryProduct;
        }

        public void selecteCategotyProduct()
        {
            switch (categoryProduct)
            {
                case "Рыбы":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\fish.jpg";
                    typesProducts = new string[] { "Тунец", "Минтай", "Белуга" };
                    break;
                case "Хлебобулочные":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\bread.jpg";
                    typesProducts = new string[] { "Ржаной хлеб", "Белый хлеб", "Зерновой хлеб" };
                    break;
                case "Мясо":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\meat.jpg";
                    typesProducts = new string[] { "Телятина", "Печень", "Стейк" };
                    break;
                case "Молочные продукты":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\milk.jpg";
                    typesProducts = new string[] { "Творог", "Йогурт", "Кефир" };
                    break;
                case "Морепродукты":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\seafood.jpg";
                    typesProducts = new string[] { "Моллюски", "Устрицы", "Мидии" };
                    break;
                case "Яйца":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\eggs.jpg";
                    typesProducts = new string[] { "Утиные", "Гусиные", "Индюшачьи" };
                    break;
                case "Овощи":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\vegetables.jpg";
                    typesProducts = new string[] { "Авокадо", "Картофель", "Томат" };
                    break;
                case "Зелень":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\greens.jpg";
                    typesProducts = new string[] { "Укроп", "Петрушка", "Зеленый лук" };
                    break;
                case "Фрукты":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\fruit.jpg";
                    typesProducts = new string[] { "Банан", "Апельсин", "Мандарин" };
                    break;
                case "Ягоды":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\berries.jpg";
                    typesProducts = new string[] { "Малина", "Клюква", "Голубика" };
                    break;
                case "Грибы":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\mushrooms.jpg";
                    typesProducts = new string[] { "Лисички", "Шампиньоны", "Белые грибы" };
                    break;
                case "Орехи":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\nuts.jpg";
                    typesProducts = new string[] { "Фундук", "Грецкие орехи", "Миндаль" };
                    break;
                case "Сладости":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\sweets.jpg";
                    typesProducts = new string[] { "Безе", "Зефир", "Ирис" };
                    break;
                case "Соки":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\juices.jpg";
                    typesProducts = new string[] { "Гранатовый", "Апельсиновый", "Яблочный" };
                    break;
                case "Газировка":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\soda.jpg";
                    typesProducts = new string[] { "Fanta", "Pepsi", "CocaCola" };
                    break;
                case "Фастфуд":
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\fast_food.jpg";
                    typesProducts = new string[] { "Картошка Фри", "Хот-дог", "Тако" };
                    break;
                default:
                    pictureProduct = Directory.GetCurrentDirectory() + @"\img\basket.jpg";
                    typesProducts = new string[] { };
                    break;
            }
        } // выбор категории товара
    }
}
