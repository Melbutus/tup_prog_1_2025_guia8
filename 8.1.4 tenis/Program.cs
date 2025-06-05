using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tenis
{
    internal class Program
    {
        static string jugador1, jugador2;
        static int setganados1, setganados2;
        static int set1jug2, set2jug2, set3jug2, set1jug1, set2jug1, set3jug1;
        static int opcion;
        static int puntos1;
        static int puntos2;
        static void Main(string[] args)
        {
            MostrarPantallaSolicitarOpcionMenu();
        }


      

        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("\tElija Opción ó -1 para finalizar\t");
            Console.WriteLine(@"1- Registrar los nombres de los dos jugadores.
2- Registrar los resultados de cada set de los jugadores.\
3- Mostrar el ganador.");

            opcion=Convert.ToInt32(Console.ReadLine());

            while (opcion != -1){ 
            switch (opcion)
            {
                case 1:
                    MostrarPantallaSolicitarNombreJugadores();
                    break;
                case 2:
                    MostrarPantallaSolicitarResultadosSet();
                    break;
                case 3:
                        DeterminarGanador();
                    break;
            }
            MostrarPantallaSolicitarOpcionMenu();
            }
        }

        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del jugador 1");
            jugador1=Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2");
            jugador2 = Console.ReadLine();

        }

        static void MostrarPantallaSolicitarResultadosSet()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el primer set del jugador 1");
            set1jug1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo set del jugador 1");
            set2jug1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer set del jugador 1");
            set3jug1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese el primer set del jugador 2");
            set1jug2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo set del jugador 2");
            set2jug2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer set del jugador 2");
            set3jug2 = Convert.ToInt32(Console.ReadLine());

        }

        static void DeterminarGanador()
        {
            Console.Clear();
            puntos1 = 0;
            puntos2 = 0;

            if (set1jug1 > set1jug2)
            {
                puntos1 += 1;
            }
            else puntos2 += 1;

            if (set2jug1 > set2jug2)
            {
                puntos1 += 1;
            }
            else puntos2 += 1;

            if (set3jug1 > set3jug2)
            {
                puntos1 += 1;
            }
            else puntos2 += 1;


            if (puntos1 > puntos2)
            {
                Console.WriteLine("El ganador es " + jugador1);
            }
            else if (puntos2 > puntos1)
            {
                Console.WriteLine("El ganador es " + jugador2);
            }

            Console.WriteLine("Presione una tecla para volver al menú...");
            Console.ReadKey();
        }




        /*static void MostrarPantallaGanador()
        {
            DeterminarGanador();
        }*/






    }

       
        
    }

