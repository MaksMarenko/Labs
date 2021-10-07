using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] nums = { 2, 3, 4, -5, 6, -7, 8, -9, 10, -11};
            //for (int i = 0; i < n; i++)
            //{
                //Console.WriteLine(nums[i]);
            //}
            Console.WriteLine(pair_unpair(nums, n));
            Console.WriteLine(pos_neg(nums, n));
            Console.ReadKey();
        }
        static int pair_unpair(int[] a, int n)
        {
            bool i2, i1 = (n > 0) && ((a[0] & 1) == 0);
            for (int i = 1; i < n; ++i)
            {
                i2 = ((a[i] & 1) == 0);
                if (i2 == i1)
                    return i;
                i1 = i2;
            }
            return -1;
        }
        static int pos_neg(int[] a, int n)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (Math.Sign(a[i]) == Math.Sign(a[i - 1]))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
