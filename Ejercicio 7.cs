using System;

namespace Ejercicio_7 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el primer numero entero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero entero: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 != number2)
            {
                if (number2 > number1)
                {
                    Console.WriteLine($"Escriba el tercer numero: ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                }
                else if (number1 > number2)
                {
                    Console.WriteLine($"Escriba el tercer numero: ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"El numero mas grande de los tres es {Math.Max(number1, number2)}");
            }
            else if (number1 == number2){
                Console.WriteLine($"Escriba el tercer numero: ");
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 == number2)
                {
                    Console.WriteLine("Los tres numeros son iguales.");
                }
                else { Console.WriteLine($"El numero mas grande de los tres es {Math.Max(number1, number2)}"); }
            }
        }
    }
}