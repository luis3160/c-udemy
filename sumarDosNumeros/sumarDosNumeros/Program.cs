using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumarDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            int num1 = 5, num2, resultado;
            //preguntamos al susuario

            Console.Write("Dame un numero para sumarlo: ");
            num2= Convert.ToInt32(Console.ReadLine());
            // convertimos la cadena en tipo int

         
            resultado = num1 + num2;

            // mostramos  en pantalla
            Console.WriteLine("el resulatado de la suma es{0}", resultado);
        }

    }
    }

