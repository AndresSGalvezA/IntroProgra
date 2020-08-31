using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: Operaciones aritméticas");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int var1 = int.Parse(num1);
            int var2 = int.Parse(num2);
            int total = var1 + var2; //Calcula la suma
            int diferencia = var1 - var2; //Calcula la resta
            int producto = var1 * var2; //Calcula el producto
            int cociente = var1 / var2; //Calcula el cociente
            int residuo = var1 % var2; //Calcula el residuo
            //Imprimir resultados
            Console.WriteLine(num1 + "+" + num2 + "=" + total);
            Console.WriteLine(num1 + "-" + num2 + "=" + diferencia);
            Console.WriteLine(num1 + "*" + num2 + "=" + producto);
            Console.WriteLine(num1 + "/" + num2 + "=" + cociente);
            Console.WriteLine(num1 + " " + "residuo" + " " + num2 + "=" + residuo);
            Console.ReadLine();
            //Comienza ejercicio 2
            Console.WriteLine("Ejercicio 2: Operaciones Booleanas");
            if (var1 > var2)
            {
                Console.WriteLine(var1 + " " + "es mayor al número" + " " + var2);
            }
            if (var1 < var2)
            {
                Console.WriteLine(var1 + " " + "es menor al número" + " "+ var2);
            }
            if (var1 == var2)
            {
                Console.WriteLine(var1 + " " + "es igual al número" + " " + var2);
            }
            Console.ReadLine();
        }
    }
}
