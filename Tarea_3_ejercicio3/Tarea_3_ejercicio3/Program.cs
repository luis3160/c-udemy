using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {// declaramos las variables a usar
            byte numero;
            string time;
            // ingresamos los datos tanto el tiepo como el formato 

            Console.WriteLine("ingresa el formato a ingresar solo horas o minutos (h/m)");
            time=Console.ReadLine();

            Console.WriteLine("ingresa el tiempo en el estacionamiento minutos o horas: ");
            numero = Convert.ToByte(Console.ReadLine());
            // aqui usamos los condicionales para practicar la logica de cada uno 

            if(numero <60 &&time== "m")
            {
                Console.WriteLine("pagaras un total de 5$");
            }
             if ((numero>=60 &&time =="m"&&numero<120 &&time=="m")||(numero<2 && time == "h")){

                Console.WriteLine("pagaras un total de 15$");
            }

            else if((numero>=2&&time =="h")||(numero>=120 && time == "m"))
            {
                Console.WriteLine("pagaras un total de 40$");
            }

        }
    }
}
