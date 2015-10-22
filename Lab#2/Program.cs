using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Unicorn unicorn = new Unicorn("Saint", 100, 60);
            unicorn.Print();
            Console.WriteLine();
            Dragon dragon = new Dragon("Fire", 200, 50);
            dragon.Print();
            Console.WriteLine();
            Dragon special = new Dragon("Morroh", 200, 80, "black dragon", "Rise!");
            special.Print();
            Console.WriteLine();
            Phoenix phoenix = new Phoenix("Rare", 100, 60);
            phoenix.Print();
            Console.WriteLine();
            phoenix.Say();
            Console.WriteLine();
            while(true)
            {
                if (phoenix.Age == 70)
                {
                    Console.WriteLine("Getting older... now I'm " + phoenix.Age + " years old.");
                    phoenix = phoenix.Ressurect();
                    phoenix.Print();
                    break;
                }
                phoenix.GetOlder();
            }
            
            Console.ReadKey();
        }
    }
}
