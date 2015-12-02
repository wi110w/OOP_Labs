namespace Lab_4
{
    using System;

    public class Gargoyle : Creature, IMonster, ITransformable, ICreature<Creature>, IFlyable
    {
        public Gargoyle(string name, uint health, uint mana)
            : base(name, health, mana)
        {
            this.Spell = "Stone!";
            this.Damage = 15;
        }

        public Gargoyle()
        {
            this.Health = 70;
            this.Mana = 40;
            this.Name = "Gargoyle";
            this.Damage = 15;
            this.Spell = "Stone!";
        }

        public string Spell
        { get; set; }

        public void Transform()
        {
            Console.WriteLine("{0}: Now I'm the statue of Liberty :>", this.Name);
        }

        public void UnTransform()
        {
            Console.WriteLine("I'm moving!");
        }

        public void Fight(Creature thing)
        {
            Console.WriteLine("The gargoyle {0} fireballed the {1}! Ouchy!", this.Name, thing.Name);
            this.Mana -= 10;
            thing.Health -= this.Damage;
        }

        public void Eat()
        {
            Console.WriteLine("OM NOM NOM NOM!");
        }

        public void Scare()
        {
            Console.WriteLine("BUGAGAGA!!!");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Spell: {0}", this.Spell);
        }

        public override void Say()
        {
            Console.WriteLine("I'm a Gargoyle!");
        }

        public void ShowFace()
        {
            Console.WriteLine(@"                       ,                   , 
                     _/(        ) (        )\_
                  _/'  `\      ((_))      /'  `\_
               _/'       `\    \~,~/    /'       `\_
            _/'            `\__/\=/\__/'            `\_
          /'               /'   ,`,   `\               `\
        /'     /'  /      |   ,{KNM},   |     \   `\     `\
      /'     /'    |       \  |/ | \|  /       |    `\     `\
    /'     /'      |    .,._\ '  |  ` /_.,.    |      `\     `\
  /'      / ,-'~-, | ,-(_  ,_`--'^`--'_,  _)-, | ,-~`-, \      `\
 /_,-'~`-/-'      `|'    ~--._`-,_,-'_.--~    `|'      `-\-'~`-,_\
/                             | | | |                             \
                              ^^^ ^^^
");
        }

        public override void React(ApocalypsisEventArgs e)
        {
            Console.WriteLine("{0}: Oh no! Transformation into stone!", this.Name);
            this.Transform();
        }
    }
}
