using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tarea_3_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Escriba un numero para saber si es par o impar: ");
            numero = Convert.ToSingle(Console.ReadLine());

            if (numero %2==0)
            {
                Console.WriteLine("el numero es par ");
            }
            else { Console.WriteLine("el numnero es impar"); }
        }
    }
}
