using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LAB 2 Варіант 12

//У всіх завданнях даного пункту потрібно вивести логічне значення
//True, якщо приведений вислів для запропонованих початкових
//даних є істинним, і значення False у супротивному випадку.Всі
//числа, для яких вказано кількість цифр (двозначне число, тризначне
//число і т.д.), вважаються цілими

//Перевірити істинність вислову: "Всі цифри даного тризначного числа різні".

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(difnumbers(num));
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("The entered data is incorrect");
                Console.ReadKey();
            }
        }

        static bool difnumbers(int num)
        {
            if(num.ToString().Length == 3)
            {
                for(int i = 0; i < num.ToString().Length; i++)
                {
                    for(int j = i + 1; j < num.ToString().Length; j++)
                    {
                        if(num.ToString()[i] == num.ToString()[j])
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The entered data is incorrect");
                return false;
            }

            return true;
        }
    }
}
