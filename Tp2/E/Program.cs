using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E
{
    internal class Program
    {

        //        codifique un programa que contenga un método llamado “ejecutarhilocincoseg()” que
        //imprima por consola la leyenda “hilo ejecutado 5” y otro método llamado
        //“ejecutarhilodiezseg()”que imprima por consola la leyenda “hilo ejecutado 10” implemente
        //el código necesario para que por medio de la ejecución de hilos el mensaje del método
        //“ejecutarhilocincoseg()” se ejecute y muestre cada 5 segundos y el mensaje del método
        //“ejecutarhilodiezseg()” se ejecute y muestre cada 10 segundos.
        static void Main(string[] args)
        {
            // Crear hilos
            Thread hiloCincoSeg = new Thread(new ThreadStart(EjecutarHiloCincoSeg));
            Thread hiloDiezSeg = new Thread(new ThreadStart(EjecutarHiloDiezSeg));

            // Iniciar hilos
            hiloCincoSeg.Start();
            hiloDiezSeg.Start();
        }
        public static void EjecutarHiloCincoSeg()
        {
            while (true)
            {
                Console.WriteLine("Hilo ejecutado 5");
                Thread.Sleep(5000); // Pausa de 5 segundos
            }
        }

        public static void EjecutarHiloDiezSeg()
        {
            while (true)
            {
                Console.WriteLine("Hilo ejecutado 10");
                Thread.Sleep(10000); // Pausa de 10 segundos
            }
        }
    }
}
