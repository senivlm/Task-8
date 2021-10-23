using System;
using System.Collections.Generic;
using System.Text;

namespace таск_8
{
    class Sortting_class : Product
    {
        public delegate bool Function(Product mas1, Product mas2);

        static public void Sort(Product[] mas, Function del) {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if (del(mas[j], mas[i]))
                    {
                        Product temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }

                }
            }
        }
        static public bool ComparisonPrice(Product mas1, Product mas2)
        {
            if (mas1 >= mas2)
                return true;
            else
                return false;
        }

        static public bool ComparisonWeight(Product mas1, Product mas2)
        {
            if (mas1 <= mas2)
                return false;
            else
                return true;
        }
    }
}
