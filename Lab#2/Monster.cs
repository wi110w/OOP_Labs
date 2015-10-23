using System;

namespace Lab_2
{
    class Monster : Creature
    {
        private string spell;
        protected Monster(string name, int health, int mana)
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
            set { spell = value; }
            get { return spell; }
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

    class Dragon : Monster
    {
        private string type;
        public Dragon(string name, int health, int mana)
            : base(name, health, mana)
        {
            Console.Write("Dragon");
            this.Spell = "Hadouken!";
        }

        public string Type 
        {
            set {type = value;}
            get {return type;}
        }

        public Dragon(string name, int health, int mana, string type, string spell)
        {
            Console.Write("Dragon");
            this.Health = health;
            this.Mana = mana;
            this.Name = name;
            this.Spell = spell;
            this.Type = type;
        }

        public Dragon()
        {
            Console.Write("Dragon");
            this.Health = 150;
            this.Mana = 100;
            this.Name = "Dragon";
            this.Spell = "Burn!";
            this.Type = "fire dragon";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Type: {0}", this.Type);
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Dragon!");
        }
    }

    class Gargoyle : Monster
    {
        public Gargoyle(string name, int health, int mana)
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

    class Manticore : Monster
    {
        public Manticore(string name, int health, int mana)
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
