using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class Program
    {

    //    1. ¿Qué es una clase?
    //Una clase es una plantilla o modelo que define las propiedades y comportamientos de un objeto.En términos más técnicos,
    //una clase es una estructura que agrupa datos (atributos) y métodos (funciones) que operan sobre esos datos. Las clases permiten crear múltiples objetos
    //con las mismas características y comportamientos.

    //    2. ¿Qué es un objeto?
    //Un objeto es una instancia de una clase. Es una entidad que tiene un estado y un comportamiento definidos por la clase de la que se creó.
    //Los objetos se utilizan para representar entidades del mundo real, como un usuario, un automóvil o una cuenta bancaria2.

    //    3. ¿Por qué se caracterizan los objetos?
    //Los objetos se caracterizan por tener:

    //Estado: Representado por los atributos o propiedades del objeto.
    //Comportamiento: Definido por los métodos o funciones del objeto.
    //Identidad: Cada objeto es único, incluso si dos objetos tienen el mismo estado y comportamiento3.
    //    4. ¿Cómo se llama la táctica de obtener la forma mínima y esencial de un objeto?
    //La táctica de obtener la forma mínima y esencial de un objeto se llama abstracción. La abstracción es un principio fundamental
    //de la programación orientada a objetos que permite simplificar la complejidad al enfocarse solo en los aspectos esenciales de un objeto, ignorando los detalles irrelevantes.


            static void Main(string[] args)
        {
        }


        public class Deposito
        {
            private string nombre { get; set; }
            private string domicilio { get; set; }
            List<Articulo> articulos { get; set; } = new List<Articulo>();
            
            public Deposito(string nombre, string domicilio)
            {
                this.nombre = nombre;
                this.domicilio = domicilio;
            }
        }

        public class Articulo
        {
            public Articulo(string codigo, double stockTotal, double stockMinimo)
            {
                this.codigo = codigo;
                this.stockTotal = stockTotal;
                this.stockMinimo = stockMinimo;
            }

            private string codigo { get; set; }
            private double stockTotal { get; set; }
            private double stockMinimo { get; set; }

            Deposito deposito { get; set; }

        }
    }
}
