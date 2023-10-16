using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Keres
    {
        public string Cim { get; set; }
        public string DatumIdo { get; set; }
        public string Get { get; set; }
        public string HttpKod { get; set; }
        public string Meret { get; set; }


        public Keres(string s)
        {
            var b = s.Split("/");
            this.Cim = b[0];
            this.DatumIdo = b[1];
            this.Get = b[2];
            this.HttpKod = b[3];
            this.Meret = b[4];
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("../../../asd.txt");


            List<Keres> lista = new List<Keres>();


            while (!sr.EndOfStream)
            {
                lista.Add(new Keres(sr.ReadLine()));
            }

            Console.WriteLine($"5.Feladat - {lista.Count} kérés található");





        }
    }
}

