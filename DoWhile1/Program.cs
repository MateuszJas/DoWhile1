using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x ;

            do
            {
                Console.WriteLine("Podaj liczbę 2<:x:>3");
                x = System.Convert.ToDouble(Console.ReadLine());

                
            } while (x <= 2 | x >= 3);

            Console.ReadKey();





        }
    }
}
