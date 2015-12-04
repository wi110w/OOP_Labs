namespace Lab_4
{
    using System;

    public class Manticore : Creature, IMonster, ICreature<Creature>, IPoisonable
    {
        public Manticore(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            this.Spell = "Poison!";
            this.Damage = 10;
        }

        public Manticore()
        {
            this.Health = 150;
            this.Mana = 70;
            this.Name = "Manticore";
            this.Damage = 10;
            this.Spell = "Poison!";
        }

        public string Spell
        {
            get;
            set;
        }

        public void Eat()
        {
            Console.WriteLine("Mmm, Yummmi! Om nom nom nom!");
        }

        public void Scare()
        {
            Console.WriteLine("Roaaaarrr! *waving scorpion's tail*");
        }

        public void Poison(Creature thing)
        {
            Console.WriteLine("The manticore {0} stabbed with tail the {1}. {1} began to die...", this.Name, thing.Name);
            Console.Write("Status poisoned {0}: ", thing.Name);
            while(thing.Health != 0)
            {
                if(thing.Health <= 5)
                {
                    thing.Health = 0;
                    break;
                }

                thing.Health -= 5;
                Console.Write("{0} ", thing.Health);
            }
            Console.WriteLine();
            Console.WriteLine("{0} is dead :<", thing.Name);
        }

        public void Fight(Creature thing)
        {
            Console.WriteLine("The manticore {0} hits with paw the {1}!", this.Name, thing.Name);
            thing.Health -= this.Damage;
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Manticore!");
        }
    }
}
