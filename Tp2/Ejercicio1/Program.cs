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

            
        }

        public class Fraccion
        {
            private int Numerador { get; set; }
            private int Denominador { get; set; }

            public Fraccion(int numerador, int denominador)
            {
           
                if (denominador == 0)
                {
                    throw new ArgumentException("El denominador no puede ser cero.");
                }

                // Simplificar la fracción al crearla
                int gcd = MCD(numerador, denominador);
                this.Numerador = numerador / gcd;
                this.Denominador = denominador / gcd;
            }

           

            private int MCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            public static Fraccion SumarFraccion(Fraccion fraccion1, Fraccion fraccion2)
            {
                int numeradorNuevo = fraccion1.Numerador * fraccion2.Denominador + fraccion2.Numerador * fraccion1.Denominador;
                int denominadorNuevo = fraccion1.Denominador * fraccion2.Denominador;
                return new Fraccion(numeradorNuevo, denominadorNuevo);
            }


            public static Fraccion RestarFraccion(Fraccion fraccion1, Fraccion fraccion2)
            {
                int numeradorNuevo = fraccion1.Numerador * fraccion2.Denominador - fraccion2.Numerador * fraccion1.Denominador;
                int denominadorNuevo = fraccion1.Denominador * fraccion2.Denominador;
                return new Fraccion(numeradorNuevo, denominadorNuevo);
            }


            public static Fraccion MultiplicarFraccion(Fraccion fraccion1, Fraccion fraccion2)
            {
                int numeradorNuevo = fraccion1.Numerador * fraccion2.Numerador;
                int denominadorNuevo = fraccion1.Denominador * fraccion2.Denominador;
                return new Fraccion(numeradorNuevo, denominadorNuevo);
            }


            public static Fraccion DividirFraccion(Fraccion fraccion1, Fraccion fraccion2)
            {
                if (fraccion2.Numerador == 0)
                {
                    throw new ArgumentException("No se puede dividir por una fracción con numerador cero.");
                }

                int numeradorNuevo = fraccion1.Numerador * fraccion2.Denominador;
                int denominadorNuevo = fraccion1.Denominador * fraccion2.Numerador;
                return new Fraccion(numeradorNuevo, denominadorNuevo);
            }
        }

    
    }
}
