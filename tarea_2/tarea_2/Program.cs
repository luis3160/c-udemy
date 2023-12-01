using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que calcule el perimetro de cualquier poligono
            // ingresamos las variables
            String nombre;
            double lado, cantidad, perimetro=0;

            // ingresamos el nombre del poligono
            Console.Write("ingresa el nombre del poligono regualar");
            nombre = Console.ReadLine();


            // ingresamos la medida de uno de los lados del poligono
            Console.Write("ingresa la medida de uno de los lados del poligono");
            lado = Convert.ToInt32 (Console.ReadLine());

            // ingresamos la cantidad de lados del poligono

            Console.Write("ingresa la cantidad de lados que tiene el poligono");
            cantidad = Convert.ToInt32(Console.ReadLine());

            //calculamos el perimetro al multiplar la cantidad de lados por la medida de uno de sus lados
            perimetro = lado * cantidad;

            //mostramos el nombre y el perimetro del poligono regular

            Console.WriteLine("El perimetro para este{0} es {1} esto es todo", nombre, perimetro);



        }
    }
}
