using System;
using System.Linq;

namespace Meth
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 18;
            //int number2 = 1;
            //var result = Add2(out number1, number2);

            //Console.WriteLine(result);
            //Console.WriteLine(number1);
            //Console.WriteLine(Multiply(3, 3));
            //Console.WriteLine(Multiply(3, 3, 10));
            Console.WriteLine(Addl(3,4,5,6,91,02,3));

            Console.ReadLine();
        }

        static int Add(int sayi1, int sayi2 = 30, int sayi3 = 10)
        {
            var result = sayi1 + sayi2 + sayi3;
            return result;
        }

        static int Add2(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

      
        static int Addl(params int[] nums)
        {
            return nums.Sum();
        }
    }
}
