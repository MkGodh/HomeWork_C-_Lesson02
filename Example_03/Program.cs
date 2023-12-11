// Показ наибольшей цифр числа в промежутк 1, 99

using System;

class Program

{
static void Main()
   {
    Console.Write("Введите число из отреза [10, 99]: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int firstDight = number / 10;
    int secondDight = number % 10;

    int maxDight = firstDight > secondDight ? firstDight : secondDight;
    Console.WriteLine(maxDight);
   }
}