﻿namespace Lab_4
{
    using System;
    
    public class Unicorn : Creature, IComparable<Creature>, ICreature<Manticore>, IEnchantable
    {
        public Unicorn(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            this.Damage = 10;
        }

        public Unicorn()
        {
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
            Console.WriteLine("The unicorn {0} hits the manticore {1}!", this.Name, manticore.Name);
            manticore.Health -= this.Damage;
            this.Mana -= 5;
        }

        public void Enchant(Creature thing)
        {
            Console.WriteLine("The unicorn {0} enchanted the {1}. {1} was stunned!", this.Name, thing.Name);
        }
    }
}
