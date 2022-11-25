﻿// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе: {sumDigit}");