namespace Lab_4
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class Dragon : Creature, IMonster, IFlyable, IComparable<Dragon>, IDragon
    {
        public Dragon(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            this.Spell = "Hadouken!";
            this.Type = "common dragon";
            this.Damage = 25;
        }

        public Dragon(string name, uint health, uint mana, string type, string spell)
        {
            this.Health = health;
            this.Mana = mana;
            this.Name = name;
            this.Spell = spell;
            this.Type = type;
            this.Damage = 35;
        }

        public Dragon()
        {
            this.Health = 150;
            this.Mana = 100;
            this.Damage = 30;
            this.Name = "Dragon";
            this.Spell = "Burn!";
            this.Type = "fire dragon";
        }

        public string Type
        {
            get;
            set;
        }

        public string Spell
        {
            get;
            set;
        }

        public int CompareTo(Dragon other)
        {
            return this.Health.CompareTo(other.Health);
        }

        public void ShowFace()
        {
            Console.WriteLine(@"                                    
             \                  /
    _________))                ((__________
   /.-------./\\    \    /    //\.--------.\
  //#######//##\\   ))  ((   //##\\########\\
 //#######//###((  ((    ))  ))###\\########\\
((#######((#####\\  \\  //  //#####))########))
 \##' `###\######\\  \)(/  //######/####' `##/
  )'    ``#)'  `##\`->oo<-'/##'  `(#''     `(
          (       ``\`..'/''       )
                     \""(
                      `- )
                      / /
                     ( /\
                     /\| \
                    (  \
                        )
                       /
                      (
                      `");
        }

        public void Fire()
        {
            Console.WriteLine("BUUUURN!!!");
            Console.WriteLine(@"
                    (  .      )
                )           (              )
                      .  '   .   '  .  '  .
             (    , )       (.   )  (   ',    )
              .' ) ( . )    ,  ( ,     )   ( .
           ). , ( .   (  ) ( , ')  .' (  ,    )
          (_,) . ), ) _) _,')  (, ) '. )  ,. (' )
        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Type: {0}", this.Type);
            Console.WriteLine("Spell: {0}", this.Spell);
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Dragon!");
        }

        public void Eat()
        {
            Console.WriteLine("Those humans are sweet. Om nom nom nom!");
        }

        public void Eat(Creature thing)
        {
            if (thing is Dragon)
            {
                Console.WriteLine("I don't wanna eat him! He's my brother!");
            }
            else
            {
                Console.WriteLine("Om nom nom nom!");
            }
        }

        public void Scare()
        {
            Console.WriteLine("I'm a Death, I'm an Evil on the wings of Night!");
        }

        public override void React(ApocalypsisEventArgs e)
        {
            Console.WriteLine("{0}: Oh, Apocalypsis is coming! Nehehehe >:D", this.Name);
        }
    }
}
