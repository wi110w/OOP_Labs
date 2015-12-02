namespace Lab_4
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class World : IComparable<World>, IEnumerable<Creature>
    {
        private List<Creature> animals = new List<Creature>();
        private int index = -1;

        public World()
        {
            animals.Add(new Pegasus("Rash", 100, 40));
            animals.Add(new Phoenix("Derek", 110, 70));
            animals.Add(new Dragon("Morroh", 200, 90, "black dragon-necromancer", "Rise and shine!"));
            animals.Add(new Dragon("Cauchy", 150, 70, "white dragon-mathematic", "For all epsilon < 0 exists delta < 0!"));
            animals.Add(new Manticore("Tremolo", 120, 30));
        }

        public Creature this[int index]
        {
            get
            {
                return animals[index];
            }
            set
            {
                animals[index] = value;
            }
        }

        public int CompareTo(World nether)
        {
            return animals[index].CompareTo(nether[index]);
        }
        
        public void Sort()
        {
            animals.Sort();
        }

        public virtual void Print()
        {
            IEnumerator<Creature> enumerator = this.GetEnumerator();
            int i = 1;
            Console.WriteLine();
            while (enumerator.MoveNext())
            {
                Creature c = (Creature)enumerator.Current;
                if (c == null)
                {
                    Console.WriteLine("{0}. NULL", i);
                }
                else
                {
                    Console.WriteLine("{0}. {1}", i, c.ToString());
                }
                i++;
            }
        }

        public IEnumerator<Creature> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        internal class Enumerator : IEnumerator<Creature>
        {
            private int currentIndex = -1;
            World netherland;

            public Enumerator(World someWorld)
            {
                this.netherland = someWorld;
            }

            public Creature Current
            {
                get { return netherland.animals[currentIndex]; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                return ++currentIndex < netherland.animals.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            void IDisposable.Dispose()
            { }
        }

        public void EraseFromWorld(int index)
        {
            if (animals[index] == null)
            {
                Console.WriteLine("This creature does not exist anymore...");
            }
            else
            {
                Console.WriteLine("{0}: Now I'm nothing...", animals[index].Name);
                animals[index].Dispose();
                animals[index] = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Memory Total Used: {0} B", GC.GetTotalMemory(false));
        }

        public virtual void ShowAboutObjAtIndex(int index)
        {
            if (animals[index] != null)
            {
                Console.WriteLine("{0} has {1} generation", animals[index].Name, GC.GetGeneration(animals[index]));
            }
            else
            {
                Console.WriteLine("This object does not exist anymore!");
            }
        }
    }
}
