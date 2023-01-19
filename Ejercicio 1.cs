using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero de dos digitos: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int digit1 = number1 / 10;
            int digit2 = number1 % 10;
            int sum = digit1 + digit2;

            Console.WriteLine($" La suma de los digitos de {number1} es: {sum}");
        }
    }
}