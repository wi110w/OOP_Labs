namespace Lab_3
{
    using System;
    
    public class Unicorn : Creature, IComparable<Creature>, ICreature<Manticore>, IEnchantable
    {
        public Unicorn(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Unicorn");
            this.Damage = 10;
        }

        public Unicorn()
        {
            Console.Write("Unicorn");
            this.Health = 100;
            this.Mana = 60;
            this.Name = "Unicorn";
            this.Damage = 10;
        }

        public override void Say()
        {
            Console.WriteLine("I'm an Unicorn!");
        }

        public int CompareTo(Creature thing)
        {
            return this.Mana.CompareTo(thing.Mana);
        }

        public void Fight(Manticore manticore)
        {
            if(manticore == null)
            {
                throw new AttackingMonsterException("Well...where is my enemy?");
            }
            Console.WriteLine("The unicorn {0} hits the manticore {1}!", this.Name, manticore.Name);
            manticore.Health -= this.Damage;
            this.Mana -= 5;
        }

        public void Enchant(Creature thing)
        {
            Console.WriteLine("The unicorn {0} enchanted the {1}. {1} was stunned!", this.Name, thing.Name);
        }

        public override void React(ApocalypsisEventArgs e)
        {
            this.Health -= e.Damage;
            Console.WriteLine("{0}: I have to save my forest!", this.Name);
        }
    }
}
