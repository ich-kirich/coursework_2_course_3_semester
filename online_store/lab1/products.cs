using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Products
    {
        private string[] productsList;

        public Products()
        {
            productsList = new string[] {};
        } // инициализация списка покупок

        public string[] getProductsList()
        {
            return productsList;
        }

        public string[] addProduct(string productToAdd)
        {
            List<string> list = productsList.ToList<string>();
            list.Add(productToAdd);
            productsList = list.ToArray();
            return productsList;
        }
    }
}
