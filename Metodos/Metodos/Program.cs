using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool continuar = false;
            while (!continuar)
            {
                bool opcioncorrecta = false;

                while (!opcioncorrecta)
                {
                    Console.WriteLine("Elija el programa que quiere ejecutar");
                    Console.WriteLine("1. Programa 1");
                    Console.WriteLine("2. Programa 2");
                    Console.WriteLine("3. Programa 3");
                    Console.WriteLine("4. Salir");
                    try
                    {
                        opcion = int.Parse(Console.ReadLine());

                        if(opcion >0 && opcion <= 4)
                        {
                            opcioncorrecta= true;
                        }
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Debe ingresar una opcion correcta");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }

                switch (opcion)
                {
                    case 1:
                        mostrar();
                        break;

                    case 2:
                        Program_2.programa2();
                        break;

                    case 3:
                        program3.progra3();
                        break;

                    case 4:
                        continuar = true;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            mostrar();
        }

        public static void mostrar()
        {
            int opcion = 0;
            bool continuar = false;
            while (!continuar)
            {
                bool opcioncorrecta = false;

                while (!opcioncorrecta)
                {
                    Console.WriteLine("Elija a que figura quiere sacarle el area");
                    Console.WriteLine("1. Area de un circulo");
                    Console.WriteLine("2. Area de un triangulo");
                    Console.WriteLine("3. Area de un cuadrado");
                    Console.WriteLine("Salir");
                    try
                    {
                        opcion = int.Parse(Console.ReadLine());

                        if (opcion > 0 && opcion <= 4)
                        {
                            opcioncorrecta = true;


                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debe ingresar un numero...");
                        Console.ReadKey();
                    }
                    Console.Clear();


                }

                switch (opcion)
                {
                    case 1:
                        circulo();
                        break;
                    case 2:
                        triangulo();

                        break;
                    case 3:
                        cuadrado();

                        break;

                    case 4:
                        continuar = true;

                        break;

                }
                Console.ReadKey();
                Console.Clear();


            }
        }
            

        public static void circulo()
        {
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = Convert.ToDouble(Console.ReadLine());
            double areaC = (Math.Pow(radio,2) * Math.PI);
            Console.WriteLine("El area del circulo es: "+areaC);
            Console.ReadKey();

        }

        public static void triangulo() 
        {
            Console.WriteLine("Ingrese la altura del triangulo");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la base del triangulo");
            double bases = Convert.ToDouble(Console.ReadLine());    


            double areaT = (bases* altura)/2;

            Console.WriteLine("El area del triangulo es: " + areaT);
            Console.ReadKey();


        }

        public  static void cuadrado() 
        {
            Console.WriteLine("Ingrese el lado del cuadrado");
            double lado = Convert.ToDouble(Console.ReadLine());


            double areaCu = Math.Pow(lado,2);

            Console.WriteLine("El area del cuadrado es: " + areaCu);
            Console.ReadKey();


        }

    }
}
