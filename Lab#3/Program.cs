namespace Lab_3
{
    using System;
    using System.Collections;
    
    public class Program
    {
        static Reaction react;
        public static void Main(string[] args)
        {
            Speaker speak = null;
            Informator info = null;
            Creature unicorn = new Unicorn("Saint", 100, 60);
            Console.WriteLine();
            Creature dragon = new Dragon("Fire", 200, 50);
            Console.WriteLine();
            Dragon special = new Dragon("Morroh", 200, 80, "black dragon", "Rise!");
            Console.WriteLine();
            Manticore manticore = new Manticore();
            Console.WriteLine();
            Creature phoenix = new Phoenix("Taurus", 100, 60);
            Console.WriteLine();
            Phoenix derek = new Phoenix("Derek", 120, 70);
            derek.Age = 55;
            Console.WriteLine();
            Gargoyle howley = new Gargoyle("Howley", 100, 60);
            Console.WriteLine();
            Unicorn trevor = new Unicorn("Trevor", 100, 60);
            Console.WriteLine();
            Pegasus rash = new Pegasus("Rash", 120, 70);
            Console.WriteLine();

            ArrayList creatures = new ArrayList();
            creatures.Add(unicorn);
            creatures.Add(derek);
            creatures.Add(special);
            creatures.Add(howley);
            creatures.Add(dragon);
            creatures.Add(phoenix);
            creatures.Add(trevor);
            creatures.Add(rash);

            foreach(Creature c in creatures)
            {
                react += c.React;
                speak += c.Say;
                info += c.Print;
            }

            info();
            Console.WriteLine();
            speak();
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                trevor.Fight(manticore);
                Console.WriteLine("{0}: {1}", manticore.Name, manticore.Health);
                trevor.Enchant(dragon);
                trevor.Fight(null);
            }
            catch(AttackingMonsterException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType(), e.Message);
            }
            Console.WriteLine();
            try
            {
                rash.Fight(howley);
                Console.WriteLine("{0}: {1}", howley.Name, howley.Health);
                Console.WriteLine();
                rash.Fight(special);
                
            }
            catch(AttackingMonsterException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType(), e.Message);
            }

            try
            {
                rash.Fight(null);
            }
            catch(AttackingMonsterException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType(), e.Message);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I summon you, Satan!");
            Demon satan = Demon.Summon("Satan!");
            satan.Print();
            Console.WriteLine();
            satan.Say();
            Console.WriteLine();
            satan.ApocalypsisEvent += new EventHandler<ApocalypsisEventArgs>(ReactionOfAnimals);
            satan.CarryChaos();
            satan.ApocalypsisEvent -= new EventHandler<ApocalypsisEventArgs>(ReactionOfAnimals);

            Console.WriteLine();
            Console.WriteLine("Damage from earthquake:");
            Console.WriteLine("{0}: {1}", unicorn.Name, unicorn.Health);
            Console.WriteLine("{0}: {1}", derek.Name, derek.Health);
            Console.WriteLine("{0}: {1}", phoenix.Name, phoenix.Health);
            Console.WriteLine("{0}: {1}", trevor.Name, trevor.Health);
            Console.WriteLine("{0}: {1}", rash.Name, rash.Health);

            Console.WriteLine();
            manticore.Poison(trevor);
            manticore.Fight(rash);
            Console.WriteLine("{0}: {1}", rash.Name, rash.Health);

            Console.ReadKey();
        }

        public static void ReactionOfAnimals(object sender, ApocalypsisEventArgs e)
        {
            react(e);
        }
    }
}
