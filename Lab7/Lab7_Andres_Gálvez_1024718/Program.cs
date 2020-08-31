using System;

namespace Lab7_Andres_Gálvez_1024718
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio");
            Circulo objCirculo = new Circulo(double.Parse(Console.ReadLine()));
            double perimetro = 0;
            double area = 0;
            double volumen = 0;
            objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);
            Console.ReadKey();
        }
    }
}
