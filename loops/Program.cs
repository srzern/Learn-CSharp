using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[] {"Amouh","Somuh","Lumouh","Cimao" };

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
