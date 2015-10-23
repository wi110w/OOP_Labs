namespace Lab_2
{
    using System;
    
    public class Monster : Creature
    {
        private string spell;

        protected Monster(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Monster -> ");
        }

        protected Monster()
        {
            Console.Write("Monster -> ");
        }

        public string Spell
        {
            get { return this.spell; }
            set { this.spell = value; }
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Health: {0}", this.Health);
            Console.WriteLine("Mana: {0}", this.Mana);
            Console.WriteLine("Spell: {0}", this.Spell);
            Console.WriteLine("Class: {0}", Creature.GetClass());
        }
    }
}
