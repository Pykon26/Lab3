using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C._1
{

    //    Cree un programa que permita ingresar por teclado dos valores enteros el primero para indicar
    //el número de filas y el segundo para el número de columnas.Mediante los 2 valores cree una
    //    matriz de 2 dimensiones de orden filas X columnas.
    //Asigne a cada elemento de la matriz el valor X si la suma de los valores enteros ingresados es
    //igual a la suma de la fila y columna de la celda caso contrario asigne una 0. (Se considera el
    //valor de la posición y no del índice de la tabla para el cálculo, es decir la primer posición es 1 no
    //0)
    //Muestre por pantalla la matriz resultante.
    //Ejemplo:
    //Valores Ingresados
    //Fila 4
    //Columna 3
    //FILA+COLUMNA = 7
    //Resultado:
    //0 0 0
    //0 0 0
    //0 0 0
    //0 0 X
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int colPlusFilas= filas+columnas;

            string[,] matriz = new string[filas, columnas];

            for (int i = 0; i < matriz.GetLength(0); i++)    
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (((i + 1) + (j + 1) == colPlusFilas)){
                        matriz[i, j]= "X";

                    }
                    else
                    {
                        matriz [i, j]= "0";
                    }
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],5} ");
                }
                Console.WriteLine();
            }

        }
    }
}
