using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero entero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero entero: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resta = Math.Abs(number1 - number2);
            if (resta <= 10)
            {
                Console.WriteLine($"Los numeros que hay entre {Math.Min(number1, number2)} y {Math.Max(number1, number2)} son los siguientes: ");
                for (int i = Math.Min(number1, number2) + 1; i <= Math.Max(number1, number2) - 1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"La resta de {Math.Min(number1, number2)}" +
                              $" y {Math.Max(number1, number2)} no es menor que 10");
        }
    }
}