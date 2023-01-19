using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool state = false;
            while (state == false)
            {
                Console.WriteLine("Escriba un numero de cuatro digitos: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 1000 & Number <= 9999)
                {
                    number = Number;
                    state = true;
                }
                else {
                    Console.WriteLine("");
                    Console.WriteLine($"{Number} no es un numero de cuatro digitos.");
                }
            }
            int digit2 = (number / 100) % 10;
            int digit3 = (number % 100) / 10;
            if (digit2 == digit3)
            {
                Console.WriteLine("El segundo y tercer digito si son iguales!");
            }
            else { Console.WriteLine("El segundo y tercer digito no son iguales."); }
        }
    }
}