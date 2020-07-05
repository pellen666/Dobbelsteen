using System;
using System.Collections.Generic;
using System.Text;

namespace Dobbelsteen
{
    class Dobbelsteen
    {
        private int AantalOgen;

        //constructor
        public Dobbelsteen()
        {
            AantalOgen = 0;
        }

        public void Gooi()
        {
            var random = new Random();
            int aantalOgen = random.Next(1, 7);
            AantalOgen = aantalOgen;
        }
        
        public int GetAantalOgen()
        {
            return AantalOgen;
        }
    }
}
