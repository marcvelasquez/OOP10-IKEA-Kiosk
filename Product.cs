using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
