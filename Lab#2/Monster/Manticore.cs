namespace Lab_2
{
    using System;

    public class Manticore : Monster
    {
        public Manticore(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Manticore");
            this.Spell = "Poison!";
        }

        public Manticore()
        {
            Console.Write("Manticore");
            this.Health = 150;
            this.Mana = 70;
            this.Name = "Manticore";
            this.Spell = "Poison!";
        }

        public override void Print()
        {
            base.Print();
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Manticore!");
        }
    }
}
