﻿namespace Lab_4
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            World netherland = new World();
            WeakWorld weakland = new WeakWorld();

            Console.WriteLine();
            Console.WriteLine("WILLKOMMEN IN WEAKLAND");
            Console.WriteLine();
            weakland.Print();
            Console.WriteLine();
            weakland.ShowInfo();
            Console.WriteLine();
            weakland.ShowAboutObjAtIndex(1);
            weakland.EraseFromWeakWorld();
            Console.WriteLine();
            weakland.Print();
            Console.WriteLine();
            weakland.ShowAboutObjAtIndex(1);
            weakland.ShowAboutObjAtIndex(2);
            Console.WriteLine();
            weakland.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("///////////////////////////////////");

            Console.WriteLine();
            Console.WriteLine("WILLKOMMEN IN NETHERLAND");
            Console.WriteLine("Before sort: ");
            netherland.Print();
            netherland.Sort();
            Console.WriteLine();
            Console.WriteLine("After sort: ");
            netherland.Print();
            Console.WriteLine();
            netherland.ShowInfo();
            netherland.ShowAboutObjAtIndex(2);
            Console.WriteLine();
            netherland.EraseFromWorld(0);
            netherland.Print();
            Console.WriteLine();
            netherland.ShowAboutObjAtIndex(2);
            netherland.ShowAboutObjAtIndex(0);
            Console.WriteLine();
            netherland.ShowInfo();
            Console.WriteLine();
            netherland.EraseFromWorld(3);
            netherland.Print();
            Console.WriteLine();
            netherland.ShowAboutObjAtIndex(2);
            Console.WriteLine();
            netherland.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("////////////////////////////////////////");

            Console.WriteLine();
            Serializator serializator = new Serializator();
            Pegasus taurus = new Pegasus("Taurus", 120, 40);
            serializator.SaveAsBinary(taurus, "taurusInfo.bin");
            serializator.LoadFromBinary("taurusInfo.bin");
            Dragon annoch = new Dragon("Annoch", 150, 60, "red dragon-warrior", "BUUURN!");
            serializator.SaveAsSoap(annoch, "annochInfo.soap");
            serializator.LoadFromSoap("annochInfo.soap");
            Gargoyle sophist = new Gargoyle("Sophist", 100, 70);
            serializator.SaveAsXml(sophist, "sophistInfo.xml");
            serializator.LoadFromXml("sophistInfo.xml");
            Console.ReadKey();
        }
    }
}
