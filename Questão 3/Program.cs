using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, h, area;
            double dm, dn, area1;
            double bm, bn, a, area2;

            Console.Write("DIGITE O VALOR DA BASE (cm): ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDIGITE O VALOR DA ALTURA (cm): ");
            h = Convert.ToDouble(Console.ReadLine());

            area = b * h / 2;

            Console.WriteLine("\nA ÁREA DO TRIANGULO É: " + area.ToString("F2") + "(cm²)");




            Console.Write("\nDIGITE O VALOR DA DIAGONAL MAIOR (cm): ");
            dm = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDIGITE O VALOR DA DIAGONAL MENOR (cm): ");
            dn = Convert.ToDouble(Console.ReadLine());

            area1 = dm * dn / 2;

            Console.WriteLine("\nA ÁREA DO LOSANGO É: " + area1.ToString("F2") + "(cm²)");



            Console.Write("\nDIGITE O VALOR DA BASE MAIOR (cm): ");
            bm = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDIGITE O VALOR DA BASE MENOR (cm): ");
            bn = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDIGITE A ALTURA (cm): ");
            a = Convert.ToDouble(Console.ReadLine());

            area2 = bm + bn * a / 2;

           Console.WriteLine("\nA ÁREA DO TRAPÉZIO É: " + area2.ToString("F2") + "(cm²)");

            Console.ReadKey();
          }
    }
}
