namespace Lab_2
{
    using System;
    
    public class Unicorn : Creature
    {
        public Unicorn(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Unicorn");
        }

        public Unicorn()
        {
            Console.Write("Unicorn");
            this.Health = 100;
            this.Mana = 60;
            this.Name = "Unicorn";
        }

        public override void Print()
        {
            base.Print();
        }

        public override void Say()
        {
            Console.WriteLine("I'm an Unicorn!");
        }
    }
}
