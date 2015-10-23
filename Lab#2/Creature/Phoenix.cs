namespace Lab_2
{
    using System;

    public class Phoenix : Creature
    {
        private int age;

        public Phoenix(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Phoenix");
            this.age = 10;
        }

        public Phoenix()
        {
            Console.Write("Phoenix");
            this.Health = 90;
            this.Mana = 30;
            this.Name = "Phoenix";
            this.Age = 0;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public bool Old
        {
            get { return this.age == 70; }
        }

        public int GetOlder()
        {
            return ++this.age;
        }

        public Phoenix Resurrect()
        {
            Console.WriteLine("I'm dying...but will be back in...");
            for (uint i = this.Health; i > 0; i--)
            {
                if (i == 60)
                {
                    Console.Write("3...");
                }

                if (i == 30)
                {
                    Console.Write("2...");
                }

                if (i == 10)
                {
                    Console.WriteLine("1...");
                }
            }

            Console.WriteLine("Happy birthday!");
            return new Phoenix();
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
