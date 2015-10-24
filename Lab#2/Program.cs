namespace Lab_2
{
    using System;
    using System.Collections;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Creature unicorn = new Unicorn("Saint", 100, 60);
            unicorn.Print();
            Console.WriteLine();
            Creature dragon = new Dragon("Fire", 200, 50);
            Console.WriteLine();
            dragon.Print();
            Console.WriteLine();
            Dragon special = new Dragon("Morroh", 200, 80, "black dragon", "Rise!");
            special.Print();
            Console.WriteLine();
            Creature manticore = new Manticore();
            manticore.Print();
            Console.WriteLine();
            Creature phoenix = new Phoenix("Taurus", 100, 60);
            phoenix.Print();
            Console.WriteLine();
            Phoenix derek = new Phoenix("Derek", 120, 70);
            derek.Print();
            Console.WriteLine();
            while (true)
            {
                if (derek.Old)
                {
                    Console.WriteLine(derek.Name + ": " + "Getting older... now I'm " + derek.Age + " years old.");
                    derek = derek.Resurrect();
                    derek.Print();
                    break;
                }

                derek.GetOlder();
            }

            Console.WriteLine();
            Console.WriteLine(special.Name + ": ");
            Dragon.ShowFace();
            Console.WriteLine();
            Console.WriteLine();
            special.Fire();
            Console.WriteLine();
            Console.WriteLine();
            ArrayList animals = new ArrayList();
            animals.Add(unicorn);
            animals.Add(dragon);
            animals.Add(manticore);
            animals.Add(phoenix);
            foreach (Creature c in animals)
            {
                Console.WriteLine();
                Console.Write(c.Name + ": ");
                c.Say();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I summon you, Satan!");
            Monster satan = Demon.Summon("Satan!");
            satan.Print();
            Console.WriteLine();
            satan.Say();
            Console.WriteLine();
            Console.WriteLine("I summon you, Abadon!");
            Monster abadon = Demon.Summon("Abadon!");
            Console.ReadKey();
        }
    }
}
