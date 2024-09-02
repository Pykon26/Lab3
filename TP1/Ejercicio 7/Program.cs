using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Length
            // Devuelve la longitud de la cadena (el número de caracteres en la cadena).
            string texto = "Hola Mundo";
            int longitud = texto.Length;
            Console.WriteLine(longitud);  // Salida: 10

            // Contains
            // Verifica si una cadena contiene una subcadena específica. Devuelve true si se encuentra la subcadena, de lo contrario false.
            bool contiene = texto.Contains("Mundo");
            Console.WriteLine(contiene);  // Salida: true

            // IndexOf
            // Devuelve el índice de la primera aparición de un carácter o subcadena dentro de la cadena. Si no se encuentra, devuelve -1.
            int indice = texto.IndexOf("Mundo");
            Console.WriteLine(indice);  // Salida: 5

            // Remove
            // Elimina una cantidad específica de caracteres de la cadena, comenzando en un índice dado.
            string resultadoRemove = texto.Remove(5, 5);
            Console.WriteLine(resultadoRemove);  // Salida: "Hola"

            // Replace
            // Reemplaza todas las apariciones de un carácter o subcadena en la cadena con otro carácter o subcadena.
            string resultadoReplace = texto.Replace("Mundo", "Amigo");
            Console.WriteLine(resultadoReplace);  // Salida: "Hola Amigo"

            // Substring
            // Extrae una subcadena de la cadena original, comenzando en un índice específico y opcionalmente hasta una longitud dada.
            string subcadena = texto.Substring(5, 5);
            Console.WriteLine(subcadena);  // Salida: "Mundo"

            // Append (Método de StringBuilder)
            // Añade una cadena al final de una instancia de StringBuilder. StringBuilder es más eficiente para concatenar cadenas repetidamente.
            StringBuilder sb = new StringBuilder("Hola");
            sb.Append(" Mundo");
            Console.WriteLine(sb.ToString());  // Salida: "Hola Mundo"

            // ToUpper
            // Convierte todos los caracteres de la cadena a mayúsculas.
            string resultadoUpper = texto.ToUpper();
            Console.WriteLine(resultadoUpper);  // Salida: "HOLA MUNDO"

            // ToLower
            // Convierte todos los caracteres de la cadena a minúsculas.
            string resultadoLower = texto.ToLower();
            Console.WriteLine(resultadoLower);  // Salida: "hola mundo"

        }
    }
}
