using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> iller = new MyDictionary<int, string>();
            iller.Add(1, "Adana");
            iller.Add(4, "Ağrı");
            iller.Add(65, "van");

            Console.WriteLine(iller.Lenght);
        }
    }
}
