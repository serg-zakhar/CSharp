﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} в кубе: {Math.Pow(i, 3)}");
}