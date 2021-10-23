using System;
using System.Collections.Generic;
using System.Text;

namespace таск_8
{
    class Product
    {
        public string name;
        public int price;
        public int weight;

        public Product() {
            name = "sfsfsd";
            price = 12131;
            weight = 124123;
        }
        public Product(string _name, int _price, int _weight)
        {
            name = _name;
            price = _price;
            weight = _weight;
        }

        public static bool operator >= (Product ob1, Product ob2)
        {
            if (ob1.price >= ob2.price)
                return true;
            return false;
        }

        public static bool operator <=(Product ob1, Product ob2)
        {
            if (ob1.weight <= ob2.weight)
                return true;
            return false;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
    }
}
