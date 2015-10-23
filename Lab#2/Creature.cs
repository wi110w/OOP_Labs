using System;

namespace Lab_2
{
    class Creature
    {
        private int health;
        private int mana;
        private string name;
        private static string kind;
        protected Creature(string name, int health, int mana) 
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

        static Creature()
        {
            Console.WriteLine("Defining class...");
            kind = "mythological animal";
        }

        public static string GetClass()
        {
            return kind;
        }

        public int Health
        {
            set { if(value >= 0) health = value; }
            get { return health; }
        }

        public int Mana
        {
            set { if (value >= 0) mana = value; }
            get { return mana; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Health: {0}", this.Health);
            Console.WriteLine("Mana: {0}", this.Mana);
            Console.WriteLine("Class: {0}", kind);
        }

        public virtual void Say() { }
    }

    class Unicorn: Creature
    {

        public Unicorn(string name, int health, int mana)
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

    class Pegasus: Creature
    {

        public Pegasus(string name, int health, int mana)
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

    class Phoenix: Creature
    {
        private int age;
        public Phoenix(string name, int health, int mana)
            : base(name, health, mana)
        {
            Console.Write("Phoenix");
            age = 10;
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public int GetOlder()
        {
            return ++age;
        }

        public bool Old
        {
            get { return age == 70; }
        }

        public Phoenix Resurrect()
        {
            Console.WriteLine("I'm dying...but will be back in...");
            for (int i = this.Health; i > 0; i--)
            {
                if (i == 60)
                    Console.Write("3...");
                if(i == 30)
                    Console.Write("2...");
                if (i == 10)
                    Console.WriteLine("1...");
            }
            Console.WriteLine("Happy birthday!");
            return new Phoenix();
        }

         public Phoenix()
        {
            Console.Write("Phoenix");
            this.Health = 90;
            this.Mana = 30;
            this.Name = "Phoenix";
            this.Age = 0;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Age: {0}", this.Age);
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Phoenix!");
        }
    }

}
