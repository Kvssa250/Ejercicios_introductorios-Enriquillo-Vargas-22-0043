using System;

namespace Ejercicio_6
{
    class Program 
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool state = false;
            while (state == false) { 
                Console.WriteLine("Escriba un numero de tres digitos: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 100 & Number <= 999) {
                    number = Number;
                    state = true;
                    Console.WriteLine($"Tu numero es {number}");
                }
            }
            int digit1 = number / 100;
            int digit2 = (number % 100) / 10;
            int digit3 = number % 10;
            var digits = new List<int> { digit1, digit2, digit3 };
            foreach (int digit in digits) {
                foreach (int i in digits) {
                    if (digit == i) { }
                    else if (digit != i) {
                        int division = digit % i;
                        if (division == 0)
                        {
                            Console.WriteLine($"{i} es multiplo de {digit}");
                            state = false;
                        }
                    }
                }
            }
            if (state == true) {
                Console.WriteLine($"Ningun digito de {number} es multiplo del otro.");
            }
        }
    }
}