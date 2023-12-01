using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ingresamos las variables
            double cercios, F_resultado;

            //ingresamos los cercios 
            Console.Write("Ingresa la cantidad de cercios a convertir: ");
            cercios = Convert.ToInt32(Console.ReadLine());

            // iniciamos la convercion

            F_resultado = (cercios * 1.8) + 32;

            //mostramos en Pantalla el resultado

            Console.Write("Este es el resultado de la conversion:{0}", F_resultado);
        }
    }
}
