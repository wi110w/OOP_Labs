namespace Lab_2
{
    using System;

    public class Pegasus : Creature
    {
        public Pegasus(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Pegasus");
        }

        public Pegasus()
        {
            Console.Write("Pegasus");
            this.Health = 120;
            this.Mana = 40;
            this.Name = "Pegasus";
        }

        public override void Print()
        {
            base.Print();
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Pegasus!");
        }
    }
}
