using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrik_Hesaplama_Console
{
    class Daire
    {

        public static double Cevre(double yaricap)
        {
            return 2 * Math.PI * yaricap;
        }


        public static double Alan(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }
    }
}
