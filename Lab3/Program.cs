using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab 3 Варіант 12

//Даний масив ненульових цілих чисел розміру N. Перевірити,
//чи чергуються в ньому 1)парні та непарні і 2) додатні і
//від ємні числа. Якщо чергуються, то вивести 0, якщо ні,
//то вивести номер першого елементу, що порушує закономірність. 

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int[] arr = new int[n] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < n; i++)
            {
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The entered data is incorrect");
                    Console.ReadKey();
                    return;
                }
            }
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = rand.Next(10);
            //    Console.WriteLine($"[{i}] {arr[i]}");
            //}

            Console.WriteLine(checkArr(arr));
            Console.ReadKey();
        }

        static bool checkArr(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
