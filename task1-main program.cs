using System;
using System.Collections.Generic;

namespace таск_8
{
    class Program
    {
        static int Menu()
        {
            int a;
            Console.WriteLine("\nWhat do you want?:");
            Console.WriteLine("1.Sorting by price");
            Console.WriteLine("2.Sorting by weight");
            Console.WriteLine("3.Exit");
            Console.WriteLine("\nYour decision:");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void Main(string[] args)
        {
            int k, size = 5;
            List<Product> p = new List<Product>(100) ;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\nInput name, price and weight:");
                p.Add(new Product()
                {
                    name = Console.ReadLine(),
                    price = Convert.ToInt32(Console.ReadLine()),
                    weight = Convert.ToInt32(Console.ReadLine())
                });
            }

            Product[] arr = new Product[100];
            arr = p.ToArray();

            do
            {
                k = Menu();
                switch (k)
                {
                    case 1:
                    Console.WriteLine("\nSORTING BY PRICE:");
                    Console.WriteLine("\nYour old mas\n:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Product:" + arr[i].name);
                        Console.WriteLine("Price:" + arr[i].price);
                        Console.WriteLine("Weight:" + arr[i].weight + '\n');
                    }

                    Sortting_class.Sort(arr, Sortting_class.ComparisonPrice);
                    Console.WriteLine("\nYour new mas\n:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Product:" + arr[i].name);
                        Console.WriteLine("Price:" + arr[i].price);
                        Console.WriteLine("Weight:" + arr[i].weight + '\n');
                    }
                        break;

                    case 2:
                    Console.WriteLine("\nSORTING BY WEIGHT:");
                    Console.WriteLine("\nYour old mas\n:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Product:" + arr[i].name);
                        Console.WriteLine("Price:" + arr[i].price);
                        Console.WriteLine("Weight:" + arr[i].weight + '\n');
                    }

                    Sortting_class.Sort(arr, Sortting_class.ComparisonWeight);
                    Console.WriteLine("\nYour new mas:\n");
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Product:" + arr[i].name);
                        Console.WriteLine("Price:" + arr[i].price);
                        Console.WriteLine("Weight:" + arr[i].weight + '\n');
                    }
                        break;
                    case 3:
                        Console.WriteLine("\nIt was a pleasure to see ya!");
                        break;
                    default:
                    Console.WriteLine("\nWRONG INPUT");
                        break;
            }
            } while (k != 3);
        }
    }
}
