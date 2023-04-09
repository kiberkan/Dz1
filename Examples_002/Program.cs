// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("Введите первое число");
int Number1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число");
int Number2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите третье число");
int Number3 = int.Parse(Console.ReadLine()!);
int Max = Number1;
if (Number2 > Max)
{
    Max = Number2;
}
if (Number3 > Max)
{
   Max = Number3; 
}
System.Console.WriteLine($"Максимальное число ={Max}");