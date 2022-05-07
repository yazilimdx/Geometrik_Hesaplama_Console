using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrik_Hesaplama_Console
{
    class Rectangle
    {

        public static double Alan(double kisakenar,double uzunkenar)
        {
            return kisakenar * uzunkenar;
        }

        public static double Cevre(double kisakenar,double uzunkenar)
        {
            return 2 * (kisakenar + uzunkenar);
        }
    }
}
