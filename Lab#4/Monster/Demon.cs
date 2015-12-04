namespace Lab_4
{
    using System;

    class Demon: Creature, IMonster
    {
        private Demon(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            this.Spell = "Fireball!";
            this.Damage = 40;
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

        public string Spell
        {
            get;
            set;
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Satan!");
        }

        public void Scare()
        {
            Console.WriteLine("Raaaaargh!!!");
        }

        public void Eat()
        {
            Console.WriteLine("Sweeet souls! Yummi!");
        }
    }
}
