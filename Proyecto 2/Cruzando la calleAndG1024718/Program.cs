using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cruzando_la_calle_Andres_Gálvez_1024718
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        //Método para tomar ancianos y mascotas.
        static public void Tomar(int xPosPer, int yPosPer, Point pIndividuo)
        {
            if (yPosPer < pIndividuo.Y + 40 && yPosPer > pIndividuo.Y - 40)
            {
                if (xPosPer < pIndividuo.X + 40 && xPosPer > pIndividuo.X - 40)
                {
                    int xAnciano1 = pIndividuo.X, yAnciano1 = pIndividuo.Y;
                    xAnciano1 = xPosPer - 10;
                    yAnciano1 = yPosPer;
                }
            }
        }

        //Métodos para detener carros simples.
        static public void DetenerIzquierda(PictureBox carroADetener, PictureBox carroFrente, Point pCarroADetener, Point pCarroFrente, Panel panel1)
        {
            if (pCarroFrente.X + carroFrente.Width > pCarroADetener.X - 10 && pCarroFrente.X + carroFrente.Width < pCarroADetener.X - 1 && pCarroFrente.Y > pCarroADetener.Y - 40 && pCarroFrente.Y < pCarroADetener.Y + 40)
            {
                //No hace nada.
            }
            else
            {
                MoverCarrosIzquierda(carroADetener, panel1);
            }
        }
        static public void DetenerDerecha(PictureBox carroADetener, PictureBox carroFrente, Point pCarroADetener, Point pCarroFrente, Panel panel1)
        {
            if (pCarroADetener.X + carroADetener.Width + 11 > pCarroFrente.X && pCarroADetener.X + carroADetener.Width < pCarroFrente.X && pCarroFrente.Y > pCarroADetener.Y - 40 && pCarroFrente.Y < pCarroADetener.Y + 40)
            {
                //No hace nada.
            }
            else
            {
                MoverCarrosDerecha(carroADetener, panel1);
            }
        }

        //Método para detener carros malos.
        static public void DetenerMalosIzquierda(PictureBox carroADetener, PictureBox carroFrente, Point pCarroADetener, Point pCarroFrente, Panel panel1, PictureBox personaje)
        {
            if (pCarroFrente.X + carroFrente.Width > pCarroADetener.X - 10 && pCarroFrente.X + carroFrente.Width < pCarroADetener.X && pCarroFrente.Y > pCarroADetener.Y - 40 && pCarroFrente.Y < pCarroADetener.Y + 40)
            {
                //No hace nada.
            }
            else
            {
                MoverCarrosMalosIzquierda(carroADetener, panel1, personaje);
            }
        }
        static public void DetenerMalosDerecha(PictureBox carroADetener, PictureBox carroFrente, Point pCarroADetener, Point pCarroFrente, Panel panel1, PictureBox personaje)
        {
            if (pCarroFrente.X == pCarroADetener.X + carroADetener.Width && pCarroFrente.X + carroFrente.Width < pCarroADetener.X && pCarroFrente.Y > pCarroADetener.Y - 40 && pCarroFrente.Y < pCarroADetener.Y + 40)
            {
                //No hace nada.
            }
            else
            {
                MoverCarrosMalosDerecha(carroADetener, panel1, personaje);
            }
        }

        //Métodos para el nivel fácil.
        static public void MoverCarrosDerecha(PictureBox carro, Panel panel1)
        {
            bool avanzar = true;
            int xCarro = carro.Location.X, yCarro = carro.Location.Y;

            if (avanzar)
            {
                carro.Left += 10;

                if (xCarro >= panel1.Width)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                carro.Location = new Point(0 - carro.Width, yCarro);
                avanzar = true;
            }
        }
        static public void MoverCarrosIzquierda(PictureBox carro, Panel panel1)
        {
            bool avanzar = true;
            int xCarro = carro.Location.X, yCarro = carro.Location.Y;

            if (avanzar)
            {
                carro.Left += -10;

                if (xCarro <= 0)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                carro.Location = new Point(carro.Width + panel1.Width, yCarro);
                avanzar = true;
            }
        }
        static public void MoverCarrosMalosDerecha(PictureBox cRojo, Panel panel1, PictureBox Personaje)
        {
            bool avanzar = true;
            int xCarro = cRojo.Location.X, yCarro = cRojo.Location.Y;
            if (avanzar)
            {
                cRojo.Left += 10;

                if (xCarro >= panel1.Width)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                cRojo.Location = new Point(0 - cRojo.Width, yCarro);
                avanzar = true;
            }

            //Validación para que el carro malo siga al personaje y no se salga de la calle.
            if (Personaje.Location.Y < 363)
            {
                if (Personaje.Location.Y > 293)
                {
                    cRojo.Top = Personaje.Top;
                }
            }
        }
        static public void MoverCarrosMalosIzquierda(PictureBox cRojo, Panel panel1, PictureBox Personaje)
        {
            bool avanzar = true;
            int xCarro = cRojo.Location.X, yCarro = cRojo.Location.Y;

            if (avanzar)
            {
                cRojo.Left += -10;

                if (xCarro <= 0)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                cRojo.Location = new Point(cRojo.Width + panel1.Width, yCarro);
                avanzar = true;
            }

            //Validación para que el carro rojo superior siga al personaje y no se salga de la calle.
            if (Personaje.Location.Y < 181)
            {
                if (Personaje.Location.Y > 110)
                {
                    cRojo.Top = Personaje.Top;
                }
            }
        }

        //Métodos para el nivel medio.
        static public void MoverCarrosDerecha2(PictureBox carro, Panel panel1)
        {
            bool avanzar = true;
            int xCarro = carro.Location.X, yCarro = carro.Location.Y;
            if (avanzar)
            {
                carro.Left += 20;

                if (xCarro >= panel1.Width)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                carro.Location = new Point(0 - carro.Width, yCarro);
                avanzar = true;
            }
        }
        static public void MoverCarrosIzquierda2(PictureBox carro, Panel panel1)
        {
            bool avanzar = true;
            int xCarro = carro.Location.X, yCarro = carro.Location.Y;

            if (avanzar)
            {
                carro.Left += -20;

                if (xCarro <= 0)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                carro.Location = new Point(carro.Width + panel1.Width, yCarro);
                avanzar = true;
            }
        }
        static public void MoverCarrosMalosDerecha2(PictureBox cRojo, Panel panel1, PictureBox Personaje)
        {
            bool avanzar = true;
            int xCarro = cRojo.Location.X, yCarro = cRojo.Location.Y;
            if (avanzar)
            {
                cRojo.Left += 10;

                if (xCarro >= panel1.Width)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                cRojo.Location = new Point(0 - cRojo.Width, yCarro);
                avanzar = true;
            }

            //Validación para que el carro malo siga al personaje y no se salga de la calle.
            if (Personaje.Location.Y < 363)
            {
                if (Personaje.Location.Y > 293)
                {
                    cRojo.Top = Personaje.Top;
                }
            }
        }
        static public void MoverCarrosMalosIzquierda2(PictureBox cRojo, Panel panel1, PictureBox Personaje)
        {
            bool avanzar = true;
            int xCarro = cRojo.Location.X, yCarro = cRojo.Location.Y;

            if (avanzar)
            {
                cRojo.Left += -10;

                if (xCarro <= 0)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                cRojo.Location = new Point(cRojo.Width + panel1.Width, yCarro);
                avanzar = true;
            }

            //Validación para que el carro rojo superior siga al personaje y no se salga de la calle.
            if (Personaje.Location.Y < 181)
            {
                if (Personaje.Location.Y > 110)
                {
                    cRojo.Top = Personaje.Top;
                }
            }
        }

        //Métodos para el nivel difícil
        static public void MoverCarrosDerecha3(PictureBox carro, Panel panel1)
        {
            bool avanzar = true;
            int xCarro = carro.Location.X, yCarro = carro.Location.Y;
            if (avanzar)
            {
                carro.Left += 20;

                if (xCarro >= panel1.Width)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                carro.Location = new Point(0 - carro.Width, yCarro);
                avanzar = true;
            }
        }
        static public void MoverCarrosIzquierda3(PictureBox carro, Panel panel1)
        {
            bool avanzar = true;
            int xCarro = carro.Location.X, yCarro = carro.Location.Y;

            if (avanzar)
            {
                carro.Left += -20;

                if (xCarro <= 0)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                carro.Location = new Point(carro.Width + panel1.Width, yCarro);
                avanzar = true;
            }
        }
        static public void MoverCarrosMalosDerecha3(PictureBox cRojo, Panel panel1, PictureBox Personaje)
        {
            bool avanzar = true;
            int xCarro = cRojo.Location.X, yCarro = cRojo.Location.Y;
            if (avanzar)
            {
                cRojo.Left += 10;

                if (xCarro >= panel1.Width)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                cRojo.Location = new Point(0 - cRojo.Width, yCarro);
                avanzar = true;
            }

            //Validación para que el carro malo siga al personaje y no se salga de la calle.
            if (Personaje.Location.Y < 363)
            {
                if (Personaje.Location.Y > 293)
                {
                    cRojo.Top = Personaje.Top;
                }
            }
        }
        static public void MoverCarrosMalosIzquierda3(PictureBox cRojo, Panel panel1, PictureBox Personaje)
        {
            bool avanzar = true;
            int xCarro = cRojo.Location.X, yCarro = cRojo.Location.Y;

            if (avanzar)
            {
                cRojo.Left += -10;

                if (xCarro <= 0)
                {
                    avanzar = false;
                }
            }

            if (avanzar == false)
            {
                cRojo.Location = new Point(cRojo.Width + panel1.Width, yCarro);
                avanzar = true;
            }

            //Validación para que el carro rojo superior siga al personaje y no se salga de la calle.
            if (Personaje.Location.Y < 181)
            {
                if (Personaje.Location.Y > 110)
                {
                    cRojo.Top = Personaje.Top;
                }
            }
        }
    }
}