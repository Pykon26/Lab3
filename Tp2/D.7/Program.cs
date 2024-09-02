using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace D._7
{

    //    En primer lugar, cree una clase base llamada Figura y luego cree clases derivadas como
    //Rectángulo, Circulo y Triangulo.//Rectángulo, Circulo y Triangulo.
    //Incluya en la clase Figura un método virtual llamado Dibujar() que imprima por consola el
    //mensaje “Dibuja Figura” y sobrescriba el método(override) en cada clase derivada para dibujar
    //la forma determinada que representa la clase, es decir que para Rectángulo el método debe
    //imprimir por consola “Dibuja Rectángulo”, para Circulo “Dibuja Circulo” y para Triangulo
    //“Dibuja Triangulo”.
    //Finalmente en el método static void Main() cree un objeto List<Figura> y agregue al mismo
    //instancias de Circulo, Triangulo y Rectángulo.
    //Utilice un bucle foreach para recorrer en iteración la lista y llamar al método Dibujar () en cada
    //objeto Figura de la lista.
    //Aunque cada objeto de la lista tiene un tipo declarado de Figura, es el tipo en tiempo de
    //ejecución el que se invocará.
    //El resultado del programa debería ser:
    //Dibuja Rectángulo
    //Dibuja Figura
    //Dibuja Círculo
    //Dibuja Figura
    //Dibuja Triangulo
    //Dibuja Figura
    internal class Program
    {
        //Rectángulo, Circulo y Triangulo.
        public class Figura
        {
            private double area {  get; set; }

            public virtual void Dibujar()
            {
                Console.WriteLine("Dibujando");
            }
        }

        public class Rectagunlo : Figura
        {
            public Rectagunlo()
            {
            }

            public override void Dibujar()
            {
                Console.WriteLine("Dibujando un rectángulo");
            }

        }
        public class Circulo : Figura
        {
            public Circulo()
            {
            }

            public override void Dibujar()
            {
                Console.WriteLine("Dibujando un Circulo");
            }
        }  
        public class Triangulo : Figura
        {
            public Triangulo()
            {
            }

            public override void Dibujar()
            {
                Console.WriteLine("Dibujando un Triangulo");
            }
        }

        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>(); 

            Triangulo triangulo = new Triangulo();
            Circulo circulo = new Circulo();  
            Rectagunlo rectagunlo = new Rectagunlo(); 
            
            list.Add(triangulo);
            list.Add(circulo);
            list.Add(rectagunlo);

            foreach (Figura figura in list)
            {
                figura.Dibujar();
            }
        }
    }
}
