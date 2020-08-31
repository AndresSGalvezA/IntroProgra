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
    public partial class RegistroDatos : Form
    {
        public RegistroDatos()
        {
            InitializeComponent();
        }

        private void BtnFacil_Click(object sender, EventArgs e)
        {
            DialogResult iniciarJuego = MessageBox.Show("¿Quieres iniciar el juego en la dificultad fácil?", "Dificultad fácil", MessageBoxButtons.OKCancel);

            if (iniciarJuego == DialogResult.OK)
            {
                Close();
                JuegoFacil objJuego = new JuegoFacil();
                objJuego.ShowDialog();
            }
        }

        private void BtnMedio_Click(object sender, EventArgs e)
        {
            DialogResult iniciarJuego = MessageBox.Show("¿Quieres iniciar el juego en la dificultad media?", "Dificultad media", MessageBoxButtons.OKCancel);

         /*   if (iniciarJuego == DialogResult.OK)
            {
                Close();
                JuegoMedio objJuego = new JuegoMedio();
                objJuego.ShowDialog();
            }*/
        }

        private void BtnDificil_Click(object sender, EventArgs e)
        {
            DialogResult iniciarJuego = MessageBox.Show("¿Quieres iniciar el juego en la dificultad difícil?", "Dificultad difícil", MessageBoxButtons.OKCancel);

            /*if (iniciarJuego == DialogResult.OK)
            {
                Close();
                JuegoDificl objJuego = new JuegoDificl();
                objJuego.ShowDialog();
            }*/
        }
    }
}
