﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите число");
int Numb = Convert.ToInt32(Console.ReadLine());
if (Numb % 2 == 1)
{
    System.Console.WriteLine("Число " +Numb+ " нечетное");
}
else
{
    System.Console.WriteLine("Число " +Numb+ " четное");
}