using System;

namespace laborator6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 1
            Un dulap are trei caracteristici : lungime, latime, inaltime. 
            Dulapul va avea o metoda care va calcula volumul acestuia.
            Folositi o clasa care va modela un dulap.
             Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
             Cele trei campuri vor fi initializate cu ajutorul constructorului
             Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
            Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
            afisati rezultatul
             */

            Dulap dulap= new Dulap(
                ReadNumber("lungime"),
                ReadNumber("latime"),
                ReadNumber("inaltime"));
            
            Console.WriteLine($"Volumul este: {dulap.VolumDulap()}");
        }

        public static string Read(string label)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.WriteLine(label);
            }
            return Console.ReadLine();
        }
        public static int ReadNumber(string label)
        {
            return int.Parse(Read(label));
        }
    }
}
