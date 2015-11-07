namespace Lab_3
{
    using System;

    public delegate void Reaction(ApocalypsisEventArgs e);
    public delegate void Informator();
    public delegate void Speaker();

    public abstract class Creature: ICreature
    {
        private static string kind;

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
        { get; set; }

        public uint Mana
        { get; set; }

        public string Name
        { get; set; }

        public uint Damage
        { get; set; }

        public static string GetClass()
        {
            return kind;
        }

        public virtual void React(ApocalypsisEventArgs e)
        {
            Console.WriteLine("{0}: We'll gonna die!", this.Name);
        }

        public virtual void React()
        {
            Console.WriteLine("{0}: We'll gonna die!", this.Name);
        }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Health: {0}", this.Health);
            Console.WriteLine("Mana: {0}", this.Mana);
            Console.WriteLine("Damage: {0}", this.Damage);
            Console.WriteLine("Class: {0}", kind);
        }

        public virtual void Say()
        {
            Console.WriteLine("I am a Creature!");
        }
    }
}
