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
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100); 
            Console.WriteLine("Ingrese el numero a buscar (1 al 100)");
            int numerobuscado = Convert.ToInt16((Console.ReadLine()));
            
            while (numerobuscado!= numeroAleatorio)
            {
                if (numerobuscado > numeroAleatorio)
                {
                    Console.WriteLine("El numero ingresado es mayor\n Ingrese otro numero");
                    numerobuscado = Convert.ToInt16((Console.ReadLine()));
                }
                else if(numerobuscado< numeroAleatorio)
                {
                    Console.WriteLine("El numero ingresado es menor\n Ingrese otro numero");
                    numerobuscado = Convert.ToInt16((Console.ReadLine()));

                }


            }

            Console.WriteLine("el numero ingresado es el correcto"+numerobuscado);
        }
    }
}
