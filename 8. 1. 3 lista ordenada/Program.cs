using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _8._1._3_lista_ordenada
{
    internal class Program
    {
        static string nombre0, nombre1, nombre2;
        static int numerolibreta0, numerolibreta1, numerolibreta2;
        static int orden, opcion;

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarMenu();
        }

        static void MostrarPantallaSolicitarMenu()
        {
            Console.WriteLine(@"1 - Registrar las notas de los tres alumnos
            2 - Mostrar lista ordenada");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarPantallaSolicitarAlumnos();
                    MostrarPantallaSolicitarMenu();
                    break;
                case 2:
                    MostrarPantallaMostrarListaOrdenada();
                    break;
            }
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
                Console.WriteLine("Ingrese nombre del alumno");
                nombre0 = Console.ReadLine();
                Console.WriteLine("Ingrese nota del alumno");
                numerolibreta0=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nombre del alumno");
                nombre1 = Console.ReadLine();
                Console.WriteLine("Ingrese nota del alumno");
                numerolibreta1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nombre del alumno");
                nombre2 = Console.ReadLine();
                Console.WriteLine("Ingrese nota del alumno");
                numerolibreta2 = Convert.ToInt32(Console.ReadLine());
                
            }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (numerolibreta0 > numerolibreta1)
            {
                if (numerolibreta0 > numerolibreta2)
                {
                    if (numerolibreta1 > numerolibreta2)
                        Console.WriteLine($"{numerolibreta0}, {numerolibreta1}, {numerolibreta2}");
                    else
                        Console.WriteLine($"{numerolibreta0}, {numerolibreta2}, {numerolibreta1}");
                }
                else
                {
                    Console.WriteLine($"{numerolibreta2}, {numerolibreta0}, {numerolibreta1}");
                }
            }
            else
            {
                if (numerolibreta1 > numerolibreta2)
                {
                    if (numerolibreta0 > numerolibreta2)
                        Console.WriteLine($"{numerolibreta1}, {numerolibreta0}, {numerolibreta2}");
                    else
                        Console.WriteLine($"{numerolibreta1}, {numerolibreta2}, {numerolibreta0}");
                }
                else
                {
                    Console.WriteLine($"{numerolibreta2}, {numerolibreta1}, {numerolibreta0}");
                }
            }

        }

    }
}
