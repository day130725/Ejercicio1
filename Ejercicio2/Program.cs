using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, prom;

            Console.Write("Ingrese nota T1 (10%)");
            n1= float.Parse(Console.ReadLine());

            Console.Write("Ingrese nota T2 (20%)");
            n2= float.Parse(Console.ReadLine());

            Console.Write("Ingrese nota T3 (30%)");
            n3= float.Parse(Console.ReadLine());

            Console.Write("Ingrese nota EF (40%)");
            n4 = float.Parse(Console.ReadLine());
            //casteo, pasteo
            prom= (n1 * 0.10) + (n2 * 0.20) + (n3 * 0.30) + (n4 * 0.40);
            Console.WriteLine("Promedio: "+prom);
            if (prom >= 11.5) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aprobado");
            }else 
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Desaprobado");
            }
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.ReadKey();
        }    
    }
}
