namespace Lab_2
{
    using System;

    public class Dragon : Monster
    {
        private string type;

        public Dragon(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Dragon");
            this.Spell = "Hadouken!";
            this.Type = "common dragon";
        }

        public Dragon(string name, uint health, uint mana, string type, string spell)
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

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public static void ShowFace()
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
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Dragon!");
        }
    }
}
