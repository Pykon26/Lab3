using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._2
{
    internal class Program
    {
       // Codifique un programa que permita la carga de una cadena de números separados por coma.
       // Al finalizar la carga ejecute la función Split de C# para separar la cadena y formar un arreglo de elementos
       // Recorra el arreglo de valores numéricos y obtenga la suma total de los valores.
       // Muestre el resultado por consola o pantalla.
        static void Main(string[] args)
        {

            Console.Write("Ingrese una cadena de números separados por coma: ");
            string entrada = Console.ReadLine();

            // Dividir la cadena en un array de strings usando Split
            string[] elementos = entrada.Split(',');
            int sumaTotal = 0;
            foreach (string elemento in elementos)
            {
                int numero = int.Parse(elemento);
                sumaTotal += numero;
            }

            // Mostrar el resultado
            Console.WriteLine($"La suma total es: {sumaTotal}\n"+ elementos.Length);

        }
    }
}
