// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Введите число");
int Numb = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool counter = true;
while (i <= Numb) 
{
    if (i % 2 != 1)
        {
        System.Console.Write($" {i}, ");
        counter = false;
    
        }
    i++;
}
if (counter)
{
    System.Console.WriteLine("Нет чётных чисел");
}