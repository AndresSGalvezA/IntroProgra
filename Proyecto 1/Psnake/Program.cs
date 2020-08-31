using System;

namespace Psnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho, alto, limiteX, limiteY;
            Console.WriteLine("Bienvenido al juego Snake");
            
            //Se le pide el ancho y el alto al usuario.
            Console.WriteLine("Ingresa el ancho de la pantalla que deseas.");
            if (int.TryParse(Console.ReadLine(), out ancho) == false) //Intenta convertir a entero si el usuario no ingresa un ancho válido.
            {
                Console.WriteLine("No ingresaste un dato válido, se usará el predefinido.");
                ancho = 10;
            }
            Console.WriteLine("");
            Console.WriteLine("Ingresa el alto de la pantalla que deseas.");
            if (int.TryParse(Console.ReadLine(), out alto) == false) //Intenta convertir a entero si el usuario no ingresa un alto válido.
            {
                Console.WriteLine("No ingresaste un dato válido, se usará el predefinido.");
                alto = 10;
            }

            Console.WriteLine("");
            Console.WriteLine("Presiona Enter para comenzar a jugar.");
            Console.ReadKey();
            Console.Clear();
            
            //Cálculo de límites.
            limiteX = ancho / 2;
            limiteY = alto / 2;

            //Definición de la serpiente y sus partes.
            Coordenada cabeza = new Coordenada(0, 0);
            Coordenada parte1 = new Coordenada(-1, 0);
            Coordenada parte2 = new Coordenada(-2, 0);
            Coordenada parte3 = new Coordenada(-3, 0);
            Coordenada cola = new Coordenada(-4, 0);

            Coordenada nuevo = new Coordenada(0,0); //Esta es la nueva posición que adoptará la cabeza de la serpiente al moverse.

            bool seguir = true;
            do
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        nuevo = new Coordenada(cabeza.X, cabeza.Y - 1); 
                        break;
                    case ConsoleKey.LeftArrow:
                        nuevo = new Coordenada(cabeza.X - 1, cabeza.Y);
                        break;
                    case ConsoleKey.RightArrow:
                        nuevo = new Coordenada(cabeza.X + 1, cabeza.Y);
                        break;
                    case ConsoleKey.UpArrow:
                        nuevo = new Coordenada(cabeza.X, cabeza.Y + 1);
                        break;
                    case ConsoleKey.X:
                        Console.Clear();
                        Console.WriteLine("Has salido del juego");
                        seguir = false;
                        break;
                }
              
                //Validación de colisión con los bordes definidos por el usuario.
                if ((nuevo.X == limiteX) || (nuevo.Y == limiteY) || (nuevo.X == -limiteX) || (nuevo.Y == -limiteY))
                {
                    Console.Clear();
                    Console.WriteLine("Has llegado al borde. Fin del juego.");
                    seguir = false;
                }
                //Validación de retroceso.
                else if ((nuevo.X == parte1.X) && (nuevo.Y == parte1.Y))
                {
                    Console.WriteLine("Has realizado un movimiento inválido");
                }
                //Validación de colisión con cola.
                else if ((nuevo.X == parte3.X) && (nuevo.Y == parte3.Y))
                {
                    Console.Clear();
                    Console.WriteLine("Has chocado con la cola. Fin del juego.");
                    seguir = false;
                }
                else
                {
                    //Lógica de movimiento.
                    cola = parte3;
                    parte3 = parte2;
                    parte2 = parte1;
                    parte1 = cabeza;
                    cabeza = nuevo;
                }

                Console.WriteLine("Las coordenadas de la cabeza son: (" + cabeza.X.ToString() + ", " + cabeza.Y.ToString() + ")");
                Console.WriteLine("La coordenadas de la cola son: (" + cola.X.ToString() + ", " + cola.Y.ToString() + ")");
            } while (seguir == true);

            Console.WriteLine("");
            Console.WriteLine("Gracias por jugar.");
            Console.WriteLine("");
            Console.WriteLine("Creadores: Génesis Cortez & Andres Gálvez (2018).");
            Console.ReadLine();
            
        }
    }
}