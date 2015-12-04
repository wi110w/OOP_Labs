namespace Lab_4
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public abstract class Creature: ICreature, IDisposable, IComparable<Creature>
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
        }

        protected Creature()
        {
        }

        public uint Health
        { get; set; }

        public uint Mana
        { get; set; }

        public string Name
        { get; set; }

        public uint Damage
        { get; set; }

        public bool IsDisposed
        { get; set; }

        public static string GetClass()
        {
            return kind;
        }

        public virtual void Print()
        {
            if (!this.IsDisposed)
            {
                Console.WriteLine();
                Console.WriteLine("Name: {0}", this.Name);
                Console.WriteLine("Health: {0}", this.Health);
                Console.WriteLine("Mana: {0}", this.Mana);
                Console.WriteLine("Damage: {0}", this.Damage);
                Console.WriteLine("Class: {0}", kind);
            }
            else
            {
                throw new ObjectDisposedException(this.Name, "This creature was disposed!");
            }
        }

        public virtual void Say()
        {
            if (!this.IsDisposed)
            {
                Console.WriteLine("I am a Creature!");
            }
            else
            {
                throw new ObjectDisposedException(this.Name, "This creature was disposed!");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(IsDisposed)
            {
                Console.WriteLine("Sorry, bro. I'm disposed :(");
            }
            else
            {
                IsDisposed = true;
            }
        }

        public override string ToString()
        {
            return Name + "(" + Health + ")";
        }

        public int CompareTo(Creature thing)
        {
            return Health.CompareTo(thing.Health);
        }

        ~Creature()
        {
            Dispose(false);
        }
    }
}
