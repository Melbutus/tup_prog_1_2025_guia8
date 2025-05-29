using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace numero
{

    internal class Program
    {
        static int edad0, edad1, edad2, edad3;
        static int suma;
        static int opcion = 0;
        static double monto, porcentaje0, porcentaje1, porcentaje2, porcentaje3;
        static double monto0, monto1, monto2, monto3;

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarOpcionMenu();
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion != -1)
            {
                switch (opcion)
                {
                    case 1:
                        registrarMontoaRepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaMontoyPorcentajePorNiña();
                        break;


                }
                MostrarPantallaSolicitarOpcionMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
            }

        }


        static void registrarMontoaRepartir()
        {
            Console.WriteLine("Ing monto");
            monto = Convert.ToDouble(Console.ReadLine());


        }
        static void RegistrarEdad(int edad, int nroEdad)
        {
            //Console.WriteLine("edad0");
            //edad0= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("edad1");
            //edad1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("edad2");
            //edad2= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("edad3");
            //edad3= Convert.ToInt32(Console.ReadLine());
            switch (nroEdad)
            {
                case 0:
                    edad0 = edad;
                    break;
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;
            }


        }
        static void CalcularMontosYPorcentajesARepartir()
        {
            suma = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = (edad0 * 100) / suma;
            porcentaje1 = (edad1 * 100) / suma;
            porcentaje2 = (edad2 * 100) / suma;
            porcentaje3 = (edad3 * 100) / suma;
            monto0 = monto * porcentaje0 / 100;
            monto1 = monto * porcentaje1 / 100;
            monto2 = monto * porcentaje2 / 100;
            monto3 = monto * porcentaje3 / 100;

        }

        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine(@"1 - Iniciar Monto a repartir
2 - Solicitar Edad Por niña
3 - Mostrar monto y porcentajes que corresponde a cada niña");

        }

        static void MostrarPantallaMontoArepartir()
        {
            Console.WriteLine($@" Monto de la 1er niña {monto0}
Monto de la 2da niña{monto1}
Monto de la 3er niña {monto2}
Monto de la 4ta niña {monto3}");
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad, i);
            }
            CalcularMontosYPorcentajesARepartir();

        }

        static void MostrarPantallaMontoyPorcentajePorNiña()
        {
            MostrarPantallaMontoArepartir();
            Console.WriteLine($@"El porcentaje de la 1er niña {porcentaje0}
El porcentaje de la 2da niña {porcentaje1}
El porcentaje de la 3ra niña {porcentaje2}
El porcentaje de la 1er niña {porcentaje3}");

        }

    }
}