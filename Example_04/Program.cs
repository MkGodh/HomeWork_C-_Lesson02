﻿class Program

{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
    

    if (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }

        else
        {
            Console.WriteLine(currentDigit);
        }
    }

}   

}