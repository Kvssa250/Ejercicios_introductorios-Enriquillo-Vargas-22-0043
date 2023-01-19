using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero de dos digitos:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 10 & number <= 99) {
                int digit1 = number / 10;
                int digit2 = number % 10;
                for (int i = 2; i < digit1; i++) {
                    if (digit1 % i == 0) {
                        Console.WriteLine($"{digit1} no es un numero primo.");
                        break;
                    } else if (digit1 % i != 0) {
                        Console.WriteLine($"{digit1} es un numero primo.");
                        break;
                    }
                }
                for (int i = 2; i < digit2; i++) {
                    if (digit2 % i == 0) {
                        Console.WriteLine($"{digit2} no es un numero primo.");
                        break;
                    } else if (digit2 % i != 0) {
                        Console.WriteLine($"{digit2} es un numero primo.");
                        break;
                    }
                }
            }
        }
    }
}