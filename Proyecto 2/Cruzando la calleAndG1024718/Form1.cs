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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LabelTitulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Andres Gálvez © URL Studio 2018", "Desarrollador");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salirJuego = MessageBox.Show("¿Realmente deseas salir del juego?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            //Ejecuta si el usuario presiona Ok en el MessageBox.
            if (salirJuego == DialogResult.OK)
            {
                Close();
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //Llama al form RegistroDatos
            RegistroDatos registroDatos = new RegistroDatos();
            registroDatos.ShowDialog();
        }

        private void BtnTop10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
