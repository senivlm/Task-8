using System.IO;
using System;
using System.Collections.Generic;
using System.Text;



namespace таск_8
{
    class Class1
    {
        static public int the_most(string[] arrs)
        {
            int first = 0, second = 0, max = 0, index_of_max = 0;
            for(int i= 1; i < arrs.Length; i++)
            {
   
                foreach(char c in arrs[i])
                {
                    if (c.Equals('('))
                        first++;
                }

                foreach (char c in arrs[i])
                {
                    if (c.Equals(')'))
                        second++;
                }

                if ((first != 0 && second != 0) && first == second)
                {
                    if (first >= max)
                    {
                        max = first;
                        index_of_max = i;
                    }
                }

                first = 0;
                second = 0;
            }
            return index_of_max;
        }
        




        static void Main(string[] args)
        {
            string str;
            int for_max;
            Strings sp = new Strings();
            string path = @"D:\c#\таск 8\таск 8\Text.txt";
            try
            {
                StreamReader file = new StreamReader(path);
                sp.S = file.ReadLine();
                str = sp.S;
                Console.WriteLine(str);
                string[] arr = str.Split('.');
          
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine('\n' + arr[i]);
                }

                for_max = the_most(arr);
                Console.WriteLine("The deeper () is №: " + (for_max + 1) + ". In sentence: " + arr[for_max]);
                file.Close();
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
//hadn`t done homework till the end