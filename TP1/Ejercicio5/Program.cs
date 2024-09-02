using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese hora de ingreso");
            double horaIngreso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese minuto de ingreso");
            double minutoIngreso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese hora de salida");
            double horaSalida = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese minuto de salida");
            double minutoSalida = Convert.ToDouble(Console.ReadLine());

            double tiempoDeIngreso = horaIngreso * 60 + minutoIngreso;
            double tiempoDeSalida = horaSalida * 60 + minutoSalida;

            //480 minutos son 8 horas


            double tiempoTrabajado = TiempoTrabajado(tiempoDeSalida, tiempoDeIngreso);

            if (ValidarHorasTrabajadas(tiempoTrabajado) && ValidarHoras(tiempoDeIngreso, tiempoDeSalida))
            {
                Console.WriteLine("La cantidad de horas trabajadas:" + MinutosAHoras(tiempoTrabajado) + "\nEl sueldo del dia seria de: " + CalcularSueldo(tiempoTrabajado));

            }

        }


        public static double CalcularSueldo(double valor)
        {
            return valor * 0.16;
        }
        public static bool ValidarHoras(double timepoIngreso, double tiempoSalida)
        {
            if (timepoIngreso > tiempoSalida)
            {
                Console.WriteLine("La hora de ingreso es mayor a la hora de salida");
                return false;
            }
            else
            {
                return true;
            }
        } public static bool ValidarHorasTrabajadas(double horasTrabajo)
        {
            if (horasTrabajo > 480)
            {
                Console.WriteLine("Las horas trabajadas son mayores a 8");
                return false;
            }
            else { return true; }
        }

        public static double TiempoTrabajado(double tiempoSalida, double tiempoEntrada)
        {
            return tiempoSalida - tiempoEntrada;
        }

        public static double MinutosAHoras(double tiempotrabajado)
        {
            return tiempotrabajado / 60;
        }

        public static double HorasAMinutos(double tiempotrabajado)
        {
            return tiempotrabajado * 60;
        }



    }
}
