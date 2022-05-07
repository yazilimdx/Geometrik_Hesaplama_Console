using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrik_Hesaplama_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islem yapmak  istediginiz geometrik sekilin numarasini giriniz:");
            Console.WriteLine("1-Ucgen\n2-Dikdortgen\n3-Daire");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Ucgenin 1.kenar uzunlugunu giriniz:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ucgenin 2.kenar uzunlugunu giriniz:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ucgenin 3.kenar uzunlugunu giriniz:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Ucgenin Alani=" + Triangle.Alan(a, b, c));
                    break;


                case 2:
                    Console.WriteLine("Dikdortgenin 1. kenar uzunlugunu giriniz:");
                    double kenar1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dikdortgenin 2. kenar uzunlugunu giriniz:");
                    double kenar2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dikdortgenin Alani=" + Rectangle.Alan(kenar1, kenar2));
                    Console.WriteLine("Dikdortgenin Cevresi=" + Rectangle.Cevre(kenar1, kenar2));
                    break;


                case 3:
                    Console.WriteLine("Dairenin yaricapini giriniz:");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dairenin Cevresi=" + Daire.Cevre(r));
                    Console.WriteLine("Dairenin Alani=" + Daire.Alan(r));
                    break;
            }
            Console.ReadKey();
        }
    }
}
