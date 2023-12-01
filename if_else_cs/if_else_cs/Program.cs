using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaramos variables
            byte opcion;
            double num1, num2, resultado = 0D;

            // aqui escribimos el menu de opciones para el usuario
            Console.WriteLine("escoja una opcion: ");
            Console.WriteLine("opcion# 1: para la suma");
            Console.WriteLine("opcion# 2: para la Resta");
            Console.WriteLine("opcion# 3: para la multiplicacion");
            Console.WriteLine("opcion# 4: para la division");
            Console.WriteLine("Escoje una de las opciones");
            //damos la entrada de datos
            opcion=Convert.ToByte(Console.ReadLine());

            // pedimos y resibimos el primer numero
            Console.Write("Dame el primer digito: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            //pedomos y recibimos el segundo digito
            Console.Write("Dame el segundo digito: ");
            num2=Convert.ToDouble(Console.ReadLine());

            // creamos los condicionales para cada una de las ecuaciones
            //SUMA
            if (opcion == 1)
            {
                resultado = num1 + num2;

            }
            else
            {
                //RESTA
                if (opcion == 2)
                {
                    resultado = num1 - num2;
                }
                else
                {
                    //MULTIPLICACION
                    if (opcion == 3)
                    {
                        resultado = num1 * num2;

                    }
                    else
                    {
                        //DIVISION
                        if (opcion == 4)
                        {

                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                            }
                            else
                            {
                                Console.Write("No se puede dividir entre cero");
                            }
                        }
                }

            }
            
            
           
            }
            //MOSTRAMOS EL MESAJE
            Console.Write("el resultado es: {0}", resultado);
        }
    }
}
