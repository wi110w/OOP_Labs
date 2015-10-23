namespace Lab_2
{
    using System;
    
    public class Program
    {
        public static void Main(string[] args)
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
            special.Say();
            Console.WriteLine();
            Manticore manticore = new Manticore();
            manticore.Print();
            Console.WriteLine();
            manticore.Say();
            Console.WriteLine();
            Phoenix phoenix = new Phoenix("Rare", 100, 60);
            phoenix.Print();
            Console.WriteLine();
            phoenix.Say();
            Console.WriteLine();
            while (true)
            {
                if (phoenix.Old)
                {
                    Console.WriteLine("Getting older... now I'm " + phoenix.Age + " years old.");
                    phoenix = phoenix.Resurrect();
                    phoenix.Print();
                    break;
                }

                phoenix.GetOlder();
            }

            Console.WriteLine();
            Console.WriteLine();
            Dragon.ShowFace();
            Console.WriteLine();
            Console.WriteLine();
            special.Fire();
            Console.ReadKey();
        }
    }
}
