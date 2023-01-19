using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero entero de dos digitos: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 10 & number <= 99) {
                for (int i = 2; i < number; i++) {
                    if (number % i == 0) {
                        Console.WriteLine($"{number} no es un numero primo");
                        break;  
                    } else if (number % i != 0) {
                        Console.WriteLine($"{number} es un numero primo");
                        break; 
                    }
                }
            }
        }
    }
}