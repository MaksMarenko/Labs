using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 //Варіант 12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter V1: ");
            int V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter t1: ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter V2: ");
            int V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter t2: ");
            int t2 = Convert.ToInt32(Console.ReadLine());

            int result = (V1 * t1 + V2 * t2) / (V1 + V2);

            Console.WriteLine($"Mixing result {V1 + V2} liters water with temperature {result} °C");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
