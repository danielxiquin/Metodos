using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class program3
    {
         
        public static void progra3()
        {
            string mostrar = "";

            Console.WriteLine("Ingrese el numero al cual se le quiere saber los divisores");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int divisor = numero % i;

                if (divisor == 0) 
                {
                    mostrar = mostrar+ " " + i;
                }

            }
            Console.WriteLine($"Los divisores del numero {numero} son {mostrar}");

        }

    }
}
