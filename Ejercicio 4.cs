using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            bool state1 = false;
            bool state2 = false;
            while (state1 == false & state2 == false) {
                Console.WriteLine("Escriba el primer numero de dos digitos: ");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                if (Number1 >= 10 & Number1 <= 99)
                {
                    state1 = true;
                    number1 = Number1;
                }
                Console.WriteLine("Escriba el primer numero de dos digitos: ");
                int Number2 = Convert.ToInt32(Console.ReadLine());
                if (Number2 >= 10 & Number2 <= 99)
                {
                    state2 = true;
                    number2 = Number2;
                }
            }
            int sum = number1 + number2;
            if (sum % 2 == 0)
            {
                Console.WriteLine($"La suma de los numeros {number1} y {number2} es igual a {sum}, el cual si es un numero par.");
            }
            else { Console.WriteLine($"La suma de los numeros {number1} y {number2} es igual a {sum}, el cual no es un numero par."); }
        }
    }
}