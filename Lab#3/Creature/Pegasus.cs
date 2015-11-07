namespace Lab_3
{
    using System;

    public class Pegasus : Creature, IFlyable, ICreature<Creature>
    {
        public Pegasus(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            Console.Write("Pegasus");
            this.Damage = 10;
        }

        public Pegasus()
        {
            Console.Write("Pegasus");
            this.Health = 120;
            this.Mana = 40;
            this.Name = "Pegasus";
            this.Damage = 10;
        }

        public void ShowFace()
        {
            Console.WriteLine(@"                              ,|
                             //|                              ,|
                           //,/                             -~ |
                         // / |                         _-~   /  ,
                       /'/ / /                       _-~   _/_-~ |
                      ( ( / /'                   _ -~     _-~ ,/'
                       \~\/'/|             __--~~__--\ _-~  _/,
               ,,)))))));, \/~-_     __--~~  --~~  __/~  _-~ /
            __))))))))))))));,>/\   /        __--~~  \-~~ _-~
           -\(((((''''(((((((( >~\/     --~~   __--~' _-~ ~|
  --==//////((''  .     `)))))), /     ___---~~  ~~\~~__--~
          ))| @    ;-.     (((((/           __--~~~'~~/
          ( `|    /  )      )))/      ~~~~~__\__---~~__--~~--_
             |   |   |       (/      ---~~~/__-----~~  ,;::'  \         ,
             o_);   ;        /      ----~~/           \,-~~~\  |       /|
                   ;        (      ---~~/         `:::|      |;|      < >
                  |   _      `----~~~~'      /      `:|       \;\_____//
            ______/\/~    |                 /        /         ~------~
          /~;;.____/;;'  /          ___----(   `;;;/
         / //  _;______;'------~~~~~    |;;/\    /
        //  | |                        /  |  \;;,\
       (<_  | ;                      /',/-----'  _>
        \_| ||_                     //~;~~~~~~~~~
            `\_|                   (,~~
                                    \~\
                                     ~~
");
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Pegasus!");
        }

        public void Fight(Creature thing)
        {
            if(thing == null)
            {
                throw new AttackingMonsterException("WTF?! Where is enemy?!");
            }
            else if (!(thing is Gargoyle))
            {
                throw new AttackingMonsterException("I can't fight with it!");
            }
            else
            {
                Console.WriteLine("The pegasus {0} hits the gargoyle {1}!", this.Name, thing.Name);
                thing.Health -= this.Damage;
            }
        }

        public override void React(ApocalypsisEventArgs e)
        {
            this.Health -= e.Damage;
            Console.WriteLine("{0}: I will battle for my family!", this.Name);
        }
    }
}
