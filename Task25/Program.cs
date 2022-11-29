/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
int degree = numberA;

for (int i = 1; i < numberB; i++)
{
degree = degree * numberA;
}
Console.WriteLine($"A в степени B равно {degree}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}