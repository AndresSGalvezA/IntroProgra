using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea9_Andres_Gálvez_1024718
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] desplazamiento = { 751, 552, 680, 965, 81, 994, 754, 981, 383, 427 };
        int[] tiempo = { 59, 40, 14, 6, 30, 45, 16, 50, 41, 12 };
        int[] aleatoTiempo = new int[10];
        double[] velocidad = new double[10];
        double[] aceleracion = new double[10];
        double promedio = 0;
        
        Random aleatorio = new Random();

        private void BtnTarea1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                velocidad[i] = desplazamiento[i] / tiempo[i];
                listBox1.Items.Add(desplazamiento[i] + " / " + tiempo[i] + " = " + velocidad[i]);
                listBox1.Items.Add(" ");
                promedio = promedio + velocidad[i];
                aleatoTiempo[i] = aleatorio.Next(1, 100);
                aceleracion[i] = velocidad[i] / aleatoTiempo[i];
                listBox2.Items.Add(velocidad[i] + " / " + aleatoTiempo[i] + " = " + aceleracion[i]);
                listBox2.Items.Add(" ");
            }

            listBox1.Items.Add("Promedio de velocidades = " + (promedio / 10));
        }

        int sumC = 0, mayorc = 0;
        string suClmn = "";
        int sumF = 0, mayorf = 0;
        string suFl = "";
        int posC = 0, posF = 0;
        int totalM = 0;
        int mayorNum = 0, menorNum = 100000;
        string posMayor = "", posMenor = "";

        private void BtnTarea2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add();
            }
            
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    dataGridView1[i, j].Value = aleatorio.Next(1, 5);
                    suClmn = dataGridView1[i, j].Value.ToString();
                    sumC = sumC + Convert.ToInt16(suClmn);

                    totalM = totalM + sumC;
                    if (Convert.ToInt16(suClmn) > mayorNum)
                    {
                        mayorNum = Convert.ToInt16(suClmn);
                        posMayor = "fila " + (j + 1) + ", columna " + (i + 1);
                    }
                    if (Convert.ToInt16(suClmn) < menorNum)
                    {
                        menorNum = Convert.ToInt16(suClmn);
                        posMenor = "fila " + (j + 1) + ", columna " + (i + 1);
                    }
                    if (sumC > mayorc)
                    {
                        mayorc = sumC;
                        posC = i + 1;
                    }
                }
                listBox3.Items.Add("La suma de la columna " + (i + 1) + " es " + sumC);
                sumC = 0; suClmn = "";
            }

            listBox3.Items.Add("");
            
            for (int i = 0; i <= 3; i++)
            {
                for (int n = 0; n <= 3; n++)
                {
                    suFl = dataGridView1[n, i].Value.ToString();
                    sumF = sumF + int.Parse(suFl);
                    if (sumF > mayorf)
                    {
                        mayorf = sumF;
                        posF = n + 1;
                    }
                }
                listBox3.Items.Add("La suma de la fila " + (i + 1) + " es " + sumF);
                sumF = 0; suFl = "";
            }
            listBox3.Items.Add("");
            listBox3.Items.Add("La fila con la mayor suma es la " + posF);
            listBox3.Items.Add("");
            listBox3.Items.Add("La columna con la mayor suma es la " + posC);
            listBox3.Items.Add("");
            listBox3.Items.Add("La suma de la matriz es " + totalM);
            listBox3.Items.Add("");
            listBox3.Items.Add("El promedio de la matriz es " + (totalM / 16));
            listBox3.Items.Add("");
            listBox3.Items.Add("El mayor número se encuentra en la " + posMayor);
            listBox3.Items.Add("");
            listBox3.Items.Add("El menor número se encuentra en la " + posMenor);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
