using System;
using System.Diagnostics;

namespace prueba
{
    internal class Program
    {
       
        static int numero, contador, acumulador;
        static int nummayor = 0, nummenor = 0;
        static int[] numeros;
        static int x = 0;
        static double promedio;

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarOpcionMenu();
            MainMenu();
        }

        static void MainMenu()
        {
            
        }

        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("\t  Menú \t");
            Console.WriteLine("1 - Procesar un solo número \r\n" +
                "2 - Procesar varios números\r\n" +
                "3 - Mostrar máximo y mínimo.\r\n" +
                "4 - Mostrar promedio.\r\n" +
                "5 - Mostrar cantidad de números ingresados.\r\n" +
                "6 - Reiniciar variables.\r\n"+
                "7 salir\n");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(" Procesar un solo número");
                    MostrarPantallaSolicitarNumero();
                    Console.ReadLine(); 
                    MostrarPantallaSolicitarOpcionMenu();
                    break;

                case "2":
                    Console.WriteLine("Procesar varios números");
                    MostrarPantallaSolicitarVariosNumeros();
                    Console.ReadLine(); 
                    MostrarPantallaSolicitarOpcionMenu();
                    break;

                case "3":
                    Console.WriteLine("Mostrar máximo y mínimo");
                    MostrarPantallaMaximo();
                    MostrarPantallaMinimo();
                    Console.ReadLine();
                    MostrarPantallaSolicitarOpcionMenu();
                    break;

                case "4":
                    Console.WriteLine("Mostrar promedio");
                    MostrarPantallaCalcularYMostrarPromedio();
                    Console.ReadLine(); 
                    MostrarPantallaSolicitarOpcionMenu();
                    break;

                case "5":
                    Console.WriteLine(" Mostrar cantidad de números ingresados");
                    MostrarPantallaCantidad();
                    Console.ReadLine(); 
                    MostrarPantallaSolicitarOpcionMenu();
                    break;

                case "6":
                    Console.WriteLine("Reiniciar variables");
                    MostrarIniciarVariables();
                    Console.ReadLine(); 
                    MostrarPantallaSolicitarOpcionMenu();
                    break;
                case "7":
                    Console.WriteLine("salir");
                    break;
            }
        }

        static void MostrarIniciarVariables()
        {
            contador = 0;
            acumulador = 0;
        }

        static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese número");
            numero = Convert.ToInt32(Console.ReadLine());
            contador += 1;
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.WriteLine("Ingrese cantidad de números a Ingresar");
            x = Convert.ToInt32(Console.ReadLine());
            numeros = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Ingrese número");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                contador += 1;
            }
        }

        static void MostrarPantallaMaximo()
        {
            if (numero > nummayor)
            {
                nummayor = numero;
            }
            Console.WriteLine($"El maximo es {nummayor}");
        }

        static void MostrarPantallaMinimo()
        {
            if (numero < nummenor)
            {
                nummenor = numero;
            }
            Console.WriteLine($"El minimo es {nummenor}");
        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            promedio = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                acumulador += numeros[i];
            }

            promedio = (double)acumulador / numeros.Length;
            Console.WriteLine($"El promedio es {promedio}");
        }

        static void MostrarPantallaCantidad()
        {
            if (numeros != null && numeros.Length > 0)
            {
                Console.WriteLine("La cantidad es: " + numeros.Length);
            }
            else
            {
                Console.WriteLine("No se han ingresado números.");
            }
        }
    }
}