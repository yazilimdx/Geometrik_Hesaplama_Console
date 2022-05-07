using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrik_Hesaplama_Console
{
   public class Triangle
    {
      public   static double Cevre(double a,double b,double c)
        {
            return a + b + c;
        }
      public   static double  Alan(double a,double b,double c)
        {
            return (1*1.0 / 4) * Math.Sqrt(Cevre(a, b, c) * (Cevre(a, b, c) - a) * (Cevre(a, b, c) - b) * (Cevre(a, b, c) - c));
        }

     
    }
}
