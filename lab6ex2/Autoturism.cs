using System;
using System.Collections.Generic;
using System.Text;

namespace lab6ex2
{
    class Autoturism
    {
        public string Marca { get; private set;}
        public string NrImatriculare { get; private set; }
        public int CapCilindrica { get; private set; }

        public Autoturism(string marca, string nrImatriculare, int capCilindrica)
        {
            Marca = marca;
            NrImatriculare = nrImatriculare;
            CapCilindrica = capCilindrica;
        }

        /// <summary>
        /// Aceasta metoda returneaza detalii despre autoturism
        /// </summary>
        /// <returns> "marca, nrImatriculare, capCilindrica" </returns>
        public string Tiparire()
        {
            return $"{Marca}, {NrImatriculare}, {CapCilindrica}";
        }
    }
}
