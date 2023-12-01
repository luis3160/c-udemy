using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toma_decicions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer una division entre dos numeros
            //
            //declaramos variables
            double resultado, dividendo, divisor;

            //ingresamos el dividendo
            Console.Write("ingrese el dividendo: ");
            dividendo=Convert.ToDouble(Console.ReadLine());

            // ingresamos el divisor
            Console.Write("ingrese el divisor: ");
            divisor=Convert.ToDouble(Console.ReadLine());

            //agregamos el condicional
            if (divisor != 0)
            {
                resultado =dividendo / divisor;

                Console.Write("{0}/{1}  = {2}", dividendo, divisor, resultado);
            }
            // agregamos otro condicional para el caso contrario y desplegamos un mensaje
           else if (divisor == 0)
            {
                Console.Write("no se puede dividir entre cero");
            }

        }
    }
}
