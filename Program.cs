using System;

namespace HundirFlota
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, a continuación se mostrará el menú de juego");

            int menu = mostrarMenu();
        }

       static int mostrarMenu() {

            /*
             * Se introduce una opción, la opción debe ser 1, 2 ó 3. Si no es una de estas mostrará un mensaje de error.
             * Se introducirán opciones hasta que se introduzca una opción válida.
             */

            int opc = 0;

            Console.WriteLine("Se presenta el juego Hundir la Flota");
            Console.WriteLine("Introduce una opción");

            Console.WriteLine("1. Jugar jugador Vs. ordenador");

            Console.WriteLine("2. Jugar jugador Vs. Jugador");

            Console.WriteLine("3. Volver");

             opc = Int32.Parse(Console.ReadLine());

            do
            {

                if (opc == 1)
                {

                    Console.WriteLine("Se ha elegido jugar Jugador Vs. Ordenador");

                    Console.WriteLine("Introduce el número de filas del tablero:");
                    int nfilas = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el número de columnas del tablero:");
                    int ncolumnas = Int32.Parse(Console.ReadLine());

                    hundir_la_flota(opc, nfilas, ncolumnas);

                }
                else if (opc == 2) {

                    Console.WriteLine("Se ha elegido jugar jugador Vs. Jugador");

                }


            } while (opc != 3);

            if (opc == 3) {

                Console.WriteLine("Volver");
            }

            return opc;
        }

       static void hundir_la_flota(int opcion, int f, int c) {

            /*
             * En esta función se reciben la opción, el número de filas y el número de columnas.
             * Por teclado se introducirá como se quiere llevar a cabo la colocación de los barcos, pudiendo ser de forma manual o de forma automática.
             */
            Console.WriteLine("Se ha elegido jugar a Hundir La Flota");

            Console.WriteLine("El número de filas del tablero es: " + f);
            Console.WriteLine("El número de columnas del tablero es: " + c);

            int opc_colocar_barcos= 0;

            Console.WriteLine("Selecciona si deseas colocar barcos de forma manual o automática.");
            Console.WriteLine("1. Será colocar barcos de forma manual. 2. Será colocar barcos de forma automática");

            do
            {
                opc_colocar_barcos = Int32.Parse(Console.ReadLine());

                

            } while (opc_colocar_barcos != 1 || opc_colocar_barcos !=2);

            if (opc_colocar_barcos == 1)
            {

            }
            else if (opc_colocar_barcos == 2) {

            }

        }

        /*Esta función habrá que retocarla muy posiblemente*/
        void colocar_barcos_manualmente(int[] t, int f, int c) {


        }

        /*Esta función habrá que retocarla muy posiblemente*/
        void colocar_barcos_automaticamente(int[] t, int f, int c) {



        }

        /*Esta función habrá que retocarla muy posiblemente*/
        void inicializar_tablero(int[] t, int f, int c) {



        }

        /*Esta función habrá que retocarla muy posiblemente*/
        void imprimir_tablero_archivo(int[] t, int f, int c) {


        }

        int comprobar_espacio_para_barco(int[] t, int f, int c, int iniFila, int iniCol, int tamBarco, int orientacion) {


            return 0;
        }

        int comprobar_disparo(int t, int f, int c, int posFila, int posCol) {


            return 0;

        }

        void jugar_manual(int f, int c) {


        }

        void jugar_automatico(int f, int c) {


        }
    }
}
