﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Таблица чисел от 1 до {number} ");
Console.WriteLine();

Console.WriteLine("Число\nКуб числа");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine("|{0}\t{1}| ", i, (i * i * i));
}