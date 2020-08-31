using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Andres_Gálvez_1024718
{
    class Circulo
    {
        private double radio;
        public Circulo(double ra)
        {
            radio = ra;
        }
        private double ObtenerPerimetro()
        {
            double per = 2 * radio * Math.PI;
            return per;
        }
        private double ObtenerArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
        private double ObtenerVolumen()
        {
            double volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
            return volumen;
        }
        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = ObtenerPerimetro();
            unArea = ObtenerArea();
            unVolumen = ObtenerVolumen();
            Console.WriteLine("El perímetro es: " + unPerimetro + ". El área es: " + unArea + ". El volumen es: " + unVolumen);
        }
    }
}
