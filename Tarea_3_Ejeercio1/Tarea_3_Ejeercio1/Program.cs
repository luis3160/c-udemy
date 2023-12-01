using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_Ejeercio1
{
    internal class Program
    {
        static void Main(string[] args)
        {// declaramos variables
            byte ano;

            // pedimos los datos y damos la entrada al dato ano
            Console.Write("Escribe un numero del 1 al 12 para reprecentar el mes del ano:  ");
            ano = Convert.ToByte(Console.ReadLine());
            // inicializamos el bueno!!
            switch (ano)
            {
                case 1:
                    Console.WriteLine("El mes es enero");
                    break;
                case 2:
                    Console.WriteLine("El mes de febrero");
                    break;

                case 3:
                    Console.WriteLine("El mes de marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes de abril");
                    break;
                case 5:
                    Console.WriteLine("El mes de mayo   ");
                    break;
                case 6:
                    Console.WriteLine("El mes de junio  ");
                    break;
                case 7:
                    Console.WriteLine("El mes de julio  ");
                    break;
                case 8:
                    Console.WriteLine("El mes de agosto ");
                    break;
                case 9:
                    Console.WriteLine("El mes de septiembre");
                    break;
                case 10:
                    Console.WriteLine("El mes de obtubre");
                    break;

                case 11:
                    Console.WriteLine("El mes de noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes de dicciembre");
                    break;
                default: Console.WriteLine("no has puesto ningun numero en el rango que te di");
                    break;
            
            }
        }
    }
}
