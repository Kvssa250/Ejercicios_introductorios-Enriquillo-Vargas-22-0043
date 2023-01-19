using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_5
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
                }
            }
            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;
            int maxNumber = digit1;
            string place = "primer";
            if (maxNumber < digit2) {
                maxNumber = digit2;
                place = "segundo";
            }
            if (maxNumber < digit3) {
                maxNumber = digit3;
                place = "tercer";
            }
            Console.WriteLine($"El numero mas grande de los digitos de {number} es {maxNumber} y se encuentra en el {place} lugar.");
        }
    }
}