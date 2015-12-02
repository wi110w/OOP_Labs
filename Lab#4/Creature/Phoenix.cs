namespace Lab_4
{
    using System;

    public class Phoenix : Creature, IResurrectable, IFlyable, IComparable<Phoenix>
    {
        private int age;

        public Phoenix(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            this.age = 10;
            this.Damage = 10;
        }

        public Phoenix()
        {
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

        public override void React(ApocalypsisEventArgs e)
        {
            this.Health -= e.Damage;
            if(this.Age >= 50)
            {
                Console.WriteLine("{0}: I'm too old to interrupt...", this.Name);
            }
            else
            {
                Console.WriteLine("{0}: I have to protect my nest!", this.Name);
            }
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

        public void ShowFace()
        {
            Console.WriteLine(@"         (                           )
                  ) )( (                           ( ) )( (
              ( ( ( )  ) )                     ( (   (  ) )(
              ) )     ,,\\\                     ///,,       ) (
           (  ((    (\\\\//                     \\////)      )
            ) )    (-(__//                       \\__)-)     (
           (((   ((-(__||                         ||__)-))    ) )
          ) )   ((-(-(_||           ```\__        ||_)-)-))   ((
          ((   ((-(-(/(/\\        ''; 9.- `      //\)\)-)-))    )
           )   (-(-(/(/(/\\      '';;;;-\~      //\)\)\)-)-)   (   )
        (  (   ((-(-(/(/(/\======,:;:;:;:,======/\)\)\)-)-))   )
            )  '(((-(/(/(/(//////:%%%%%%%:\\\\\\)\)\)\)-)))`  ( (
           ((   '((-(/(/(/('uuuu:WWWWWWWWW:uuuu`)\)\)\)-))`    )
             ))  '((-(/(/(/('|||:wwwwwwwww:|||')\)\)\)-))`    ((
          (   ((   '((((/(/('uuu:WWWWWWWWW:uuu`)\)\))))`     ))
                ))   '':::UUUUUU:wwwwwwwww:UUUUUU:::``     ((   )
                  ((      '''''''\uuuuuuuu/``````         ))
                    ))            `JJJJJJJJJ`           ((
                     ((            LLLLLLLLLLL         ))
                       ))         ///|||||||\\\       ((
                         ))      (/(/(/(^)\)\)\)       ((
                           ((                           ))
                             ((                       ((
                               ( )( ))( ( ( ) )( ) (()");
        }

        public int CompareTo(Phoenix other)
        {
            return this.Age.CompareTo(other.Age);
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
