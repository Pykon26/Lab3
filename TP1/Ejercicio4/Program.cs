using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seleccione una operacion con simbolos(+ - / * %)");
            string operacion = Console.ReadLine();
            while(operacion != "+" && operacion != "/" && operacion != "-" && operacion != "*" && operacion != "%")
            {
                Console.WriteLine("Operacion ingresada no valida, \n Ingrese otra operacion");
                operacion = Console.ReadLine();

            }

            switch (operacion)
            {
                case "+":
                    {
                        Console.WriteLine("El resultado de la suma es " + Sumar(num1, num2));
                        break;
                    };
                case "-":
                    {
                        Console.WriteLine("El resultado de la resta es " + Restar(num1, num2));
                        break;
                    };
                case "/":
                    {
                        Console.WriteLine("El resultado de la division es " + Division(num1, num2));
                        break;
                    };
                case "*":
                    {
                        Console.WriteLine("El resultado de la multiplicacion es " + Multiplicar(num1, num2));
                        break;
                    };
                case "%":
                    {
                        Console.WriteLine("El resultado de la resta es " + Resto(num1, num2));
                        break;
                    };


            }


        }

        public static double Sumar(double num1,double num2)
        {
            return num1 + num2;
        } public static double Restar(double num1,double num2)
        {
            return num1 - num2;
        } public static double Multiplicar(double num1,double num2)
        {
            return num1 * num2;
        } public static double Division(double num1,double num2)
        {
            return num1 / num2;
        } public static double Resto(double num1,double num2)
        {
            return num1 % num2;
        }
    }
}
