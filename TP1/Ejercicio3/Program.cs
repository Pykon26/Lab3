using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int numero = rn.Next(0, 100);
            if (esPar(numero))
            {
                Console.WriteLine("el numero es par " + numero);
            }
            else {
                Console.WriteLine("el numero no es par " + numero);}

            
        }

        public static bool esPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
