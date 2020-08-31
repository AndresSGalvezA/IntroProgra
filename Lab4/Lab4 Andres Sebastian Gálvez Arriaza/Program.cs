using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Andres_Sebastian_Gálvez_Arriaza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comienza ejercicio 1
            Console.WriteLine("Operaciones aritméticas");
            Console.WriteLine("Ingrese un número");
            int x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            int x2 = int.Parse(Console.ReadLine());
            int suma = x1 + x2;
            int resta = x1 - x2;
            int multiplicación = x1 * x2;
            int división = x1 / x2;
            int residuo = x1 % x2;
            Console.WriteLine(x1 + " + " + x2 + " = " + suma);
            Console.WriteLine(x1 + " - " + x2 + " = " + resta);
            Console.WriteLine(x1 + " * " + x2 + " = " + multiplicación);
            Console.WriteLine(x1 + " / " + x2 + " = " + división);
            Console.WriteLine(x1 + " residuo " + x2 + " = " + residuo);
            Console.ReadKey();

            //Comienza ejercicio 2
            Console.WriteLine(" ");
            Console.WriteLine("Operaciones booleanas");
            if (x1 > x2)
            {
                Console.WriteLine(x1 + " es mayor que " + x2);
            }
            else if (x1 < x2)
            {
                Console.WriteLine(x1 + " es menor que " + x2);
            }
            else if (x1 == x2)
            {
                Console.WriteLine(x1 + " es igual a " + x2);
            }
            Console.ReadKey();

            //Ejercicio 3
            Console.WriteLine(" ");
            Console.WriteLine("Jerarquía de operaciones");
            Console.WriteLine("Ingrese un número");
            int nu1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            int nu2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un tercer número");
            int nu3 = Convert.ToInt16(Console.ReadLine());
            int res1 = nu1 * nu2 + nu3;
            int res2 = nu1 * (nu2 + nu3);
            int res3 = nu1 / (nu2 * nu3);
            int res4 = ((3 * nu1) + (2 * nu2)) / (nu3 ^ 2);
            Console.WriteLine("Resultado 1 = " + res1);
            Console.WriteLine("Resultado 2 = " + res2);
            Console.WriteLine("Resultado 3 = " + res3);
            Console.WriteLine("Resultado 4 = " + res4);
            Console.ReadKey();

            //Ejercicio 4
            Console.WriteLine(" ");
            Console.WriteLine("Ecuación cuadrática");
            double a = Convert.ToDouble(nu1);
            double b = Convert.ToDouble(nu2);
            double c = Convert.ToDouble(nu3);
            double ba2 = Math.Pow(b, 2); //Eleva al cuadrado 
            double raizI = ba2 - (4 * a * c); // Calcula la expresión dentro de la raíz
            double raiz = Math.Sqrt(raizI); //Calcula la raíz
            double answer1 = (-b + raiz) / (2 * a); //Calcula la primer respuesta de la ecuación
            double answer2 = (-b - raiz) / (2 * a); //Calcula la segunda respuesta de la ecuación
            Console.WriteLine("x = " + answer1);
            Console.WriteLine("x = " + answer2);
            Console.ReadKey();

            //Tarea
            Console.WriteLine(" ");
            Console.WriteLine("Tarea");
            Console.WriteLine("Andres Sebastian Gálvez Arriaza - 1024718");
            Console.WriteLine("Ingrese el monto");
            double din = double.Parse(Console.ReadLine());
            double bills100 = Math.Truncate(din / 100); //Calcula billetes de 100
            double bills50 = Math.Truncate((din - (bills100 * 100)) / 50); //Calcula billetes de 50
            double bills20 = Math.Truncate(((din - (bills100 * 100)) - (bills50 * 50)) / 20); //Calcula billetes de 20
            double bills10 = Math.Truncate(((din - (bills100 * 100)) - (bills50 * 50) - (bills20 * 20)) / 10); //Calcula billetes de 10
            double bills5 = Math.Truncate(((din - (bills100 * 100)) - (bills50 * 50) - (bills20 * 20) - (bills10 * 10)) / 5); //Calcula billetes de 5
            double mons1 = Math.Truncate((din - (bills100 * 100)) - (bills50 * 50) - (bills20 * 20) - (bills10 * 10) - (bills5 * 5)); //Calcula monedas de 1
            double centTotal = Math.Round(((din - (bills100 * 100)) - (bills50 * 50) - (bills20 * 20) - (bills10 * 10) - (bills5 * 5) - mons1) * 100); //Aisla los centavos
            double cents25 = Math.Truncate(centTotal / 25); 
            double cents1 = centTotal - (cents25 * 25);
            Console.WriteLine(bills100 + " billete(s) de 100 quetzales");
            Console.WriteLine(bills50 + " billete(s) de 50 quetzales");
            Console.WriteLine(bills20 + " billete(s) de 20 quetzales");
            Console.WriteLine(bills10 + " billete de 10 quetzales");
            Console.WriteLine(bills5 + " billete de 5 quetzales");
            Console.WriteLine(mons1 + " monedas de 1 quetzal");
            Console.WriteLine(cents25 + " monedas de 25 centavos de quetzal");
            Console.WriteLine(cents1 + " monedas de 1 centavo de quetzal");
            Console.ReadKey();
        } 
    }
}