using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program_2
    {
        public static void programa2 () 
        {
            double preciobase = 0  ;
            double peso = 0;
            double preciofinal=0;

            double[] energia = new double[4] {100,80,60,50};
            Console.WriteLine("Ingrese el precio del producto elegido");
            preciobase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el consumo del electrodomestico (letras A-D)");
            string opcion = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese el peso del electrodomestico (kg) mayor que 20");
            peso = Convert.ToDouble(Console.ReadLine());

            switch (opcion)
            {

                case "A":

                    if(peso > 20 && peso < 40)
                    {
                        preciofinal = energia[0] + (energia[0] * 0.05) ;
                        preciofinal = preciofinal + preciobase;
                    }else if (peso >= 40)
                    {
                        preciofinal = energia[0] + (energia[0] * 0.10);
                        preciofinal = preciofinal + preciobase;

                    }

                    break;
                case "B":
                    if (peso > 20 && peso < 40)
                    {
                        preciofinal = energia[1] + (energia[0] * 0.05);
                        preciofinal = preciofinal + preciobase;

                    }
                    else if (peso >= 40)
                    {
                        preciofinal = energia[1] + (energia[0] * 0.10);
                        preciofinal = preciofinal + preciobase;

                    }

                    break;
                case "C":
                    if (peso > 20 && peso < 40)
                    {
                        preciofinal = energia[2] + (energia[0] * 0.05);
                        preciofinal = preciofinal + preciobase;

                    }
                    else if (peso >= 40)
                    {
                        preciofinal = energia[3] + (energia[0] * 0.10);
                        preciofinal = preciofinal + preciobase;

                    }

                    break;
                case "D":
                    if (peso > 20 && peso < 40)
                    {
                        preciofinal = energia[4] + (energia[0] * 0.05);
                        preciofinal = preciofinal + preciobase;

                    }
                    else if (peso >= 40)
                    {
                        preciofinal = energia[4] + (energia[0] * 0.10);
                        preciofinal = preciofinal + preciobase;

                    }

                    break;
                
            }
            Console.WriteLine("El precio total del producto es: " + preciofinal);
            Console.WriteLine("El número energetico: " + opcion);
            Console.WriteLine("El peso del producto es: " + peso);
            Console.ReadKey();












        }
    }
}
