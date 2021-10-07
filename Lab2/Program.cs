using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            double nk = 1.0;
            int nn = 6;
            int p = (3 * k + (-1) ^ (k ^ 2 - k + 1) * k) / (2 * k ^ 2 + 1);
            for (int i = 1; i <= nn; i++)
            {
                nk *= pow(1.0 + 1.0, i);
            }
            Console.WriteLine(nk);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }

        static double pow(double a, int k)
        {
            int p = 1;
            for (int i = 1; i <= k; i++)
            {
                p *= Convert.ToInt32(a);
            }
            return p;
        }
    }
}
