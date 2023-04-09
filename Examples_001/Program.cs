//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите два числа число");
int Number1 = int.Parse(Console.ReadLine()!);
int Number2 = int.Parse(Console.ReadLine()!);
if (Number1 > Number2) 
{
    int Max = Number1;
    int Min = Number2;
    System.Console.WriteLine($"Максимальное число ={Max}, Минимальное число ={Min}");
} 
else 
{
    int Max = Number2;
    int Min = Number1;
    System.Console.WriteLine($"Максимальное число ={Max}, Минимальное число ={Min}");
}