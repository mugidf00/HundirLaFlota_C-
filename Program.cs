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

                    if (nfilas < 8)
                    {
                        do
                        {

                            Console.WriteLine("Introduce el número de filas del tablero:");

                            nfilas = Int32.Parse(Console.ReadLine());

                        } while (nfilas < 8);

                    }

                    Console.WriteLine("Introduce el número de columnas del tablero:");
                    int ncolumnas = Int32.Parse(Console.ReadLine());

                    if(ncolumnas < 8){

                        do
                        {
                            Console.WriteLine("Introduce el número de columnas del tablero");

                            ncolumnas = Int32.Parse(Console.ReadLine());

                        } while (ncolumnas < 8);

                    }

                    hundir_la_flota(opc, nfilas, ncolumnas);

                }
                else if (opc == 2) {
                    //TODO
                    /*Implementar lo que hace aquí.*/
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

            opc_colocar_barcos = Int32.Parse(Console.ReadLine());

            while (opc_colocar_barcos != 1 && opc_colocar_barcos != 2) {

                Console.WriteLine("Aquí la mangaba, a ver ahora....");
                Console.WriteLine("Introduce la opción nuevamente");
                opc_colocar_barcos = Int32.Parse(Console.ReadLine());

            }
            if (opc_colocar_barcos == 1){

                int[,] tablero = new int[f, c];

                for (int i = 0; i < f; i++) {

                    for(int j = 0; j < c; j++){

                        tablero[i, j] = 0;
                    }

                }

                imprimirTablero(tablero);
                Console.WriteLine("Se ha pintado el tablero");
               colocar_barcos_manualmente(tablero);

            }
            else if (opc_colocar_barcos == 2) {

            }

        }

        static void imprimirTablero(int[,] t) {

            for (int i = 0; i < t.Length; i++) {

                for (int j = 0; j < t.GetLength(1); j++) {

                    Console.Write("\t" + t[i, j]);
                }

                Console.WriteLine();
            }

        }

        /*Esta función habrá que retocarla muy posiblemente*/
        static void colocar_barcos_manualmente(int[,] t) {

            Console.WriteLine("Se procederá a colocar los barcos de forma manual");

            int num_barcos_tam1 = 3;
            int num_barcos_tam2 = 2;
            int num_barcos_tam3 = 1;

            /*
             * Se podrán introducir barcos en el tablero siempre que haya barcos disponibles.
             * Para poder introducir un barco en una casilla es necesario comprobar que esa casilla tenga un 0.
             */

            do {

                Console.WriteLine("Introduce la fila y columna donde desdesas colocar el barco, fila y columna deben estar dentro del rango.");
                int f = Int32.Parse(Console.ReadLine());
                int c = Int32.Parse(Console.ReadLine());

                for(int i = 0; i < t.Length; i++){

                    for (int j = 0; j < t.GetLength(1); j++) {

                        if (t[i, j] == 0) {

                            Console.WriteLine("La casilla: ["+f+","+c+"] está vacía, se puede introducir un barco");

                        }


                    }
                        
                }





            } while (num_barcos_tam1 > 0 || num_barcos_tam2 > 0 || num_barcos_tam3 > 0);



        }

        /*Esta función habrá que retocarla muy posiblemente*/
        void colocar_barcos_automaticamente(int[,] t, int f, int c) {



        }

        /*Esta función habrá que retocarla muy posiblemente*/
        void inicializar_tablero(int[,] t, int f, int c) {



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
