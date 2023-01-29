using System;
using System.Collections.Generic;
using System.Text;

namespace laborator6
{
    class Dulap
    {
        private int _lungime;
        private int _latime;
        private int _inaltime;

        public Dulap(int lungime, int latime, int inaltime )
        {
            _lungime = lungime;
            _latime = latime;
            _inaltime = inaltime;
        }
        public int VolumDulap()
        {
            var result = _inaltime * _latime* _lungime;
            return result;
        }
    }
}
