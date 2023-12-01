using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador_or
{
    internal class Program
    {
        static void Main(string[] args)
        {// declaramos variables
            String color;

            // pedimos el color e ingresamos el valor
            Console.Write("ingrese el color RGB");
            color = Console.ReadLine();
            // usamos la sentencia switch

            switch (color)
            {
                case "read":

                    Console.Write("255,0,,");
                    break;

                case "green": Console.Write("0,255,0");
                    break;

                case "blue": Console.Write("0,0,255");
                    break;
            }
            
            
        }
    }
}
