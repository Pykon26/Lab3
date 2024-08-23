using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for ( i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            i = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            while (i <= 100)
            {

                if (i % 2 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            i = 0;

            Console.WriteLine("~~~~~~~~~~~~~~~~~");

            do
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 100);

        }
    }
}
