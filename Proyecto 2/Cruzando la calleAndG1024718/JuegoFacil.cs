using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruzando_la_calle_Andres_Gálvez_1024718
{
    public partial class JuegoFacil : Form
    {
        public JuegoFacil()
        {
            InitializeComponent();
            TimerCarros.Start();
            TimerPunteo.Start();
        }

        private void TimerPunteo_Tick(object sender, EventArgs e)
        {
            //Algoritmo para dar marcha al tiempo de juego.
            int tiempoRestante = int.Parse(LblTiempoRestante.Text);
            tiempoRestante--;
            LblTiempoRestante.Text = tiempoRestante.ToString();

            //Al faltar 15 segundos de juego, el color del texto de la etiqueta se vuelve rojo.
            if (LblTiempoRestante.Text == "15")
            {
                LblTiempoRestante.ForeColor = Color.Red;
            }

            //Detiene todo al terminar el tiempo.
            if (LblTiempoRestante.Text == "0")
            {
                TimerCarros.Stop();
                TimerPunteo.Stop();
                MessageBox.Show("Se acabó el tiempo, inténtalo de nuevo.", "Fin del juego");
            }

            //Validación para cambiar la cantidad de ancianos restantes.
            if (anciano1.Location.Y < 58)
            {
                LblAncianos.Text = "1";
            }

            //Validación para cambiar la cantidad de ancianos restantes.
            if (anciano2.Location.Y < 58)
            {
                LblAncianos.Text = "0";
            }

            //Validación para cambiar la cantidad de mascotas restantes.
            if (mascota1.Location.Y < 58)
            {
                LblMascotas.Text = "0";
            }

            //Validación para ganar el juego.
            if (LblAncianos.Text == "0" && LblMascotas.Text == "0")
            {
                TimerPunteo.Stop();
                TimerCarros.Stop();
                MessageBox.Show("¡Felicidades! Has ganado el nivel fácil.", "Nivel superado");
            }
        }

        //Método para mover al personaje.
        private void JuegoFacil_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Personaje.Location.X, y = Personaje.Location.Y;

            switch (e.KeyData)
            {
                case Keys.Up:
                    if (y >= 0) //Se ejecuta media vez el personaje se encuentre dentro de los límites.
                    {
                        Personaje.Location = new Point(x, y - 10);

                        
                    }
                    break;

                case Keys.Down:
                    if (y + Personaje.Height <= panel1.Height) //El personaje no puede salir del extremo inferior.
                    {
                        Personaje.Location = new Point(x, y + 10);
                    }
                    break;

                case Keys.Left:
                    if (x >= 0) //El personaje no puede salir del extremo izquierdo.
                    {
                        Personaje.Image = Image.FromFile("PersonajeIzq.gif"); //Rota la imagen del personaje.
                        Personaje.Location = new Point(x - 10, y);
                    }
                    break;

                case Keys.Right:
                    if (x + Personaje.Width <= panel1.Width) //El personaje no puede salir del extremo derecho.
                    {
                        Personaje.Image = Image.FromFile("PersonajeDer.gif"); //Rota la imagen del personaje.
                        Personaje.Location = new Point(x + 10, y);
                    }

                    Program.Tomar(Personaje.Location.X, Personaje.Location.Y, anciano1.Location);
                    break;

                //Toma un anciano o una mascota.
                case Keys.A:
                    Program.Tomar(Personaje.Location.X, Personaje.Location.Y, anciano1.Location);
                    break; 

                //Libera un anciano o una mascota.
               /* case Keys.R:
                    if (true)
                    {

                    }
                    break; */
            }
        }

        private void TimerCarros_Tick(object sender, EventArgs e)
        {
            //Detiene el carro Azul inferior ---------
            Program.DetenerDerecha(carroAzul1, Personaje, carroAzul1.Location, Personaje.Location, panel1);

            Program.MoverCarrosDerecha(carroAmarillo1, panel1);
            Program.MoverCarrosMalosDerecha(carroRojo, panel1, Personaje);

            Program.MoverCarrosIzquierda(carroAzul2, panel1);

            //Detiene el carro amarillo superior cuando el carro verde está enfrente.
            Program.DetenerIzquierda(carroAmarillo2, carroVerde, carroAmarillo2.Location, carroVerde.Location, panel1);

            //Detiene el carro verde cuando el personaje está enfrente.
            Program.DetenerIzquierda(carroVerde, Personaje, carroVerde.Location, Personaje.Location, panel1);

            //Detiene el carro rojo cuando tiene un carro enfrente.
            Program.DetenerMalosIzquierda(carroRojo2, carroAmarillo2, carroRojo2.Location, carroAmarillo2.Location, panel1, Personaje);
        }
    }
}
