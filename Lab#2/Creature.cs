namespace Lab_2
{
    using System;

    public class Creature
    {
        private static string kind;
        private uint health;
        private uint mana;
        private string name;

        static Creature()
        {
            Console.WriteLine("Defining class...");
            kind = "mythological animal";
        }

        protected Creature(string name, uint health, uint mana)
        {
            this.Health = health;
            this.Mana = mana;
            this.Name = name;
            Console.Write("Creature -> ");
        }

        protected Creature()
        {
            Console.Write("Creature -> ");
        }

        public uint Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public uint Mana
        {
            get { return this.mana; }
            set { this.mana = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public static string GetClass()
        {
            return kind;
        }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Health: {0}", this.Health);
            Console.WriteLine("Mana: {0}", this.Mana);
            Console.WriteLine("Class: {0}", kind);
        }

        public virtual void Say()
        {
        }
    }
}
