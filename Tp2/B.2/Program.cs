using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2
{
    internal class Program
    {

        //Cree una aplicación de Consola que permita por parte del usuario el ingreso por teclado de una
        //cadena de texto, posteriormente el sistema deberá permitir el ingreso de una segunda cadena
        //de texto.Finalmente el sistema deberá emitir el mensaje “ENCONTRADO” o “NO
        //ENCONTRADO” según sean el caso de que la segunda cadena existe o no existe en la primera
        //cadena.Valide que la cantidad de caracteres de la segunda cadena sea menor o igual a la
        //cantidad de caracteres de la primera cadena.
        //Ej.:
        //Entrada Cadena 1: jhsjdhsjdhsd8787dsdsds8ds8d7sd6ds76d
        //Entrada Cadena 2: ds8ds8d
        //Resultado: “ENCONTRADO”
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la primer cadena de texto");
            string cadena1 = Console.ReadLine();


            Console.WriteLine("Ingrese la primer cadena de texto");
            string cadena2 = Console.ReadLine();

            while (cadena1.Length < cadena2.Length)
            {
                Console.WriteLine("La segunda cadena no puede ser mas larga que la primer cadena \nIngrese la segunda cadena nuevamente");
                cadena2 = Console.ReadLine();
                
            }


            if (cadena1.Contains(cadena2)) { Console.WriteLine("Encontrado"); } else { Console.WriteLine("No encontrado");}


        }

        

    }
}
