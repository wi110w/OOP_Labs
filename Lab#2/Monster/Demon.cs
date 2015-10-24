namespace Lab_2
{
    using System;
    class Demon: Monster
    {
        private Demon(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.WriteLine("Demon");
            this.Spell = "Fireball!";
        }

        public static Demon Summon(string spell)
        {
            if (spell != "Satan!")
            {
                Console.WriteLine("Sorry, we haven't this demon :(");
                return null;
            }
            
           return new Demon("Satan", 200, 100);
        }

        public override void Print()
        {
            base.Print();
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Satan!");
        }
    }
}
