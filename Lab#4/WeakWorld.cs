namespace Lab_4
{
    using System;
    using System.Collections.Generic;

    class WeakWorld : World
    {
        private List<WeakReference> weakAnimals = new List<WeakReference>();

        public WeakWorld()
        {
            weakAnimals.Add(new WeakReference(new Unicorn(), false));
            weakAnimals.Add(new WeakReference(new Manticore(), true));
            weakAnimals.Add(new WeakReference(new Dragon(), false));
            weakAnimals.Add(new WeakReference(new Pegasus(), true));
        }

        public Creature this[int index]
        {
            get
            {
                Creature thing = weakAnimals[index].Target as Creature;

                return thing;
            }
        }

        public void EraseFromWeakWorld()
        {
            Console.WriteLine("GC: Bye-Bye!");
            GC.Collect();
        }

        public override void ShowAboutObjAtIndex(int index)
        {
            if (weakAnimals[index].IsAlive)
            {
                Console.WriteLine("{0} has {1} generation.", weakAnimals[index].Target, GC.GetGeneration(weakAnimals[index].Target));
            }
            else
            {
                Console.WriteLine("This creature is dead :(");
            }
        }

        public override void Print()
        {
            for (int i = 0; i < weakAnimals.Count; i++)
            {
                if (weakAnimals[i].IsAlive)
                {
                    Console.WriteLine("{0}. {1}", i + 1, weakAnimals[i].Target);
                }
                else
                {
                    Console.WriteLine("{0}. NULL", i + 1);
                }
            }
        }

    }
}
