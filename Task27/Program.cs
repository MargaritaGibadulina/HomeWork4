﻿/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int number = ReadInt("Введите число: ");
int sum = 0;

while (number != 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine($"Сумма цифр в числе равна {sum}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
