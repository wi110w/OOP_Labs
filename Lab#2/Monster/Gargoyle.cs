namespace Lab_2
{
    using System;

    public class Gargoyle : Monster
    {
        public Gargoyle(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Gargoyle");
            this.Spell = "Stone!";
        }

        public Gargoyle()
        {
            Console.Write("Gargoyle");
            this.Health = 70;
            this.Mana = 40;
            this.Name = "Gargoyle";
            this.Spell = "Stone!";
        }

        public override void Print()
        {
            base.Print();
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Gargoyle!");
        }
    }
}
