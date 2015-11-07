namespace Lab_3
{
    using System;

    public class ApocalypsisEventArgs : EventArgs
    {
        public uint Damage { get; set; }
    }

    class Demon: Creature, ISummonable, IMonster
    {
        public event EventHandler<ApocalypsisEventArgs> ApocalypsisEvent;

        private Demon(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.WriteLine("Demon");
            this.Spell = "Fireball!";
            this.Damage = 40;
        }

        public static Demon Summon(string spell)
        {
            if (spell != "Satan!")
            {
                Console.WriteLine("Sorry, we haven't this demon :(");
                return null;
            }
            
           return new Demon("Satan", 200, 100);
        }

        public string Spell
        {
            get;
            set;
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Satan!");
        }

        protected virtual void OnApocalypsisBegan(ApocalypsisEventArgs e)
        {
            if (ApocalypsisEvent != null)
                ApocalypsisEvent(this, e);
        }

        public void CarryChaos()
        {
            ApocalypsisEventArgs args = new ApocalypsisEventArgs();
            Console.WriteLine("*earthquake, million demons began carry the chaos in the name of Satan*");
            args.Damage = 10;
            OnApocalypsisBegan(args);
        }

        public void Scare()
        {
            Console.WriteLine("Raaaaargh!!!");
        }

        public void Eat()
        {
            Console.WriteLine("Sweeet souls! Yummi!");
        }
    }
}
