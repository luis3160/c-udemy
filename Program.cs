using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.Write("cual es tu nombre?:");
            nombre = Console.ReadLine();
            //Saludamos al usuario

            Console.WriteLine("Hola {0} Es un placer conocerte",nombre);
        }
    }
}
