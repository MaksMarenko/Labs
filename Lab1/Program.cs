using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//LAB 1
//Написати програму, що виконує наступні функції:

//1.Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
//2.Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)

//3.Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)

//4.Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)

//5.Виконати пункт 4 з використанням ключових слів ref i out




namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[] {1,3,5,7,15,1234,62 };
            RevArrayWithRef(ref result);
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }

        public static string RevStr(string str)
        {
            string reversed = string.Empty;
            foreach (char i in str)
            {
                reversed = i + reversed;
            }

            return reversed;
        }
        public static int RevInt(int input)
        {
            int reversed = 0;
            while (input > 0)
            {
                reversed = reversed * 10 + input % 10;
                Console.WriteLine(input % 10);
                input /= 10;
            }
            return reversed;
        }
        public static double RevDouble(double input)
        {
            double reversed = 0;
            string result = string.Empty;
            string left = string.Empty;
            string right = string.Empty;
            int num = 0;
            for(int i = 0; i < input.ToString().Length; i++)
            {
                if (input.ToString()[i] == '.')
                {
                    num = i;
                    break;
                }
                left = input.ToString()[i] + left;
            }
                
            for(int i = num+1; i < input.ToString().Length; i++)
            {
                right = input.ToString()[i] + right;
            }

            result = left + "." + right;
            reversed = Convert.ToDouble(result);

            return reversed;
        }
        public static string RevTextWithSym(string input)
        {
            string result = string.Empty;
            string left = string.Empty;
            string right = string.Empty;
            int num = 0;
            for (int i = 0; i < input.ToString().Length; i++)
            {
                if (input.ToString()[i] == ',')
                {
                    num = i;
                    break;
                }
                left = input.ToString()[i] + left;
            }

            for (int i = num + 1; i < input.ToString().Length; i++)
            {
                right = input.ToString()[i] + right;
            }

            result = left + "," + right;

            return result;
        }
        public static int[] RevArray(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - i -1];
            }

            return result;
        }
        public static void RevArrayWithRef(ref int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - i - 1];
            }
            arr = result;
        }
    }
}
