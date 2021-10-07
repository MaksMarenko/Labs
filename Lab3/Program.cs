using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i,k,j;
            string s;
 
            Console.Write("Enter num:");
            a = Convert.ToInt32(Console.ReadLine());
            s = a.ToString();
            k = s.Length;
            if (k == 3) 
            {
                for (i = 0; i < k - 1; i++)
                    for ( j =i+1; j < k; j++)
                        if (s[i] == s[j])
                        {
                            Console.Write("There are the same numbers");
                            goto end;
                        }
            }
            else
            {
                Console.Write("This number is not 3-digit");
                Console.ReadKey();
                Environment.Exit(1);
            }
            Console.Write("All numbers are different");
            end:
            Console.ReadKey();
        }
    }
}
