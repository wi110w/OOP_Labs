﻿namespace Lab_4
{
    using System;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Runtime.Serialization.Formatters.Soap;
    using System.Xml.Serialization;
    using System.IO;

    class Serializator
    {
        private BinaryFormatter binFormatter = new BinaryFormatter();
        private SoapFormatter soapFormatter = new SoapFormatter();
        private XmlSerializer xmlFormatter = new XmlSerializer(typeof(Gargoyle));
        
        public void SaveAsBinary(object objGraph, string filename)
        {
            using(Stream writer = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormatter.Serialize(writer, objGraph);
            }
            Console.WriteLine("->Object was saved in binary format");
        }

        public void LoadFromBinary(string filename)
        {
            using (Stream reader = File.OpenRead(filename))
            {
                Pegasus pegasFromFile = (Pegasus)binFormatter.Deserialize(reader);
                Console.WriteLine("<-Object was loaded from file");
                pegasFromFile.ShowFace();
            }
        }

        public void SaveAsSoap(object objGraph, string filename)
        {
            using(Stream writer = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(writer, objGraph);
            }
            Console.WriteLine("->Object was saved in SOAP format");
        }

        public void LoadFromSoap(string filename)
        {
            using(Stream reader = File.OpenRead(filename))
            {
                Dragon dragonFromFile = (Dragon)soapFormatter.Deserialize(reader);
                Console.WriteLine("<-Object was loaded from file");
                dragonFromFile.ShowFace();
            }
        }

        public void SaveAsXml(object objGraph, string filename)
        {
            using(Stream writer = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormatter.Serialize(writer, objGraph);
            }
            Console.WriteLine("->Object was saved in XML format");
        }

        public void LoadFromXml(string filename)
        {
            using(Stream reader = File.OpenRead(filename))
            {
                Gargoyle gargoyleFromFile = (Gargoyle)xmlFormatter.Deserialize(reader);
                Console.WriteLine("<-Object was loaded from file");
                gargoyleFromFile.Print();
                gargoyleFromFile.ShowFace();
            }
        }
    }
}
