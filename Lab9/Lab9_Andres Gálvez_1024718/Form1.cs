using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Andres_Gálvez_1024718
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDatos_Click(object sender, EventArgs e)
        {
            int[] val = new int[5];
            val[0] = Convert.ToInt16(textBox1.Text);
            val[1] = Convert.ToInt16(textBox2.Text);
            val[2] = Convert.ToInt16(textBox3.Text);
            val[3] = Convert.ToInt16(textBox4.Text);
            val[4] = Convert.ToInt16(textBox5.Text);

            string valores = "";
            int total = 0;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i <= 4; i++)
            {
                valores = valores + " " + val[i];
                total = total + val[i];
            }

            for (int i = 0; i <= 4; i++)
            {
                if ((val[i] % 2) == 0)
                {
                    pares = pares + val[i];
                }

                else
                {
                    impares = impares + val[i];
                }
            }

            MessageBox.Show("Los números ingresados son " + valores, "Números ingresados");
            MessageBox.Show("La suma de estos es " + total, "Suma de valores");
            MessageBox.Show("La longitud del vector es de " + val.Length, "Longitud");
            MessageBox.Show("La suma de los números pares es " + pares, "Suma de pares");
            MessageBox.Show("La suma de los números impares es " + impares, "Suma de impares");

            int[,] aleatorios = new int[10, 3];
            int j = 0;

            Random nums = new Random();

            for (int i = 0; i <= 9; i++)
            {
                aleatorios[i, j] = nums.Next(0, 100);
                aleatorios[i, (j + 1)] = (aleatorios[i, j]) * 2;
                aleatorios[i, (j + 2)] = (aleatorios[i, j] + aleatorios[i, (j + 1)]) / 2;
            }

            listBox1.Items.Add("Números aleatorios");

            for (int i = 0; i <= 9; i++)
            {
                listBox1.Items.Add(aleatorios[i, j] + "   " + aleatorios[i, (j + 1)] + "   " + aleatorios[i, (j + 2)]);
                listBox1.Items.Add("");
            }
        }

        int contFila = 0;
        private void BtnAgregarFila_Click(object sender, EventArgs e)
        {
            if (contFila == 7)
            {
            }

            else
            {
                dgv_Tablero.Rows.Add();
                contFila++;
            }

            for (int i = 0; i <= contFila; i++)
            {
                if (i == 0)
                {
                    dgv_Tablero.Rows[0].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    if ((i % 2) != 0)
                    {
                        dgv_Tablero.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                        dgv_Tablero.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    }
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}