﻿using System;
using System.Linq;

namespace lab6ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 2
             Scrieti un program care va modela un autoturism. Un autoturism va avea o
             marca (string), un numar de inmatriculare (string), precum si o
             capacitate cilindrica(int).
             Autoturismul va avea:
              Campurile corespunzatoare caracteristicilor autoturismului.
              Un constructor care va initializa campurile acestuia
              O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : 
            “marca, numarDeInmatriculare, capacitateCilindrica”.
             Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
             xml pentru metodele publice.
             Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
             metodele “Tipareste”
             */

            Autoturism autoturism = new Autoturism(
                Read("marca"), 
                Read("nrImatriculare"),
                int.Parse(Read("capCilindrica")));
            Console.WriteLine(autoturism.Tiparire());

            Autoturism autoturism2 = new Autoturism(
                Read("marca"),
                Read("nrImatriculare"),
                int.Parse(Read("capCilindrica")));
            Console.WriteLine(autoturism2.Tiparire());

        }

        public static string Read(string label)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.WriteLine(label);
            }
            return Console.ReadLine();
        }
    }
}
