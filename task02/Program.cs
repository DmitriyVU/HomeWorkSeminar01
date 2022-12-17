/* Домашнее задание задача 4
Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.WriteLine("Привет, введи Имя:");
string name = (Console.ReadLine());
Console.WriteLine(name + ",введите 1-ое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(name + ",введите 2-ое число");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(name + ",введите 3-е число");
int Num3 = Convert.ToInt32(Console.ReadLine());
int max = Num1;

if (Num2 > max)
{
    max = Num2;
}

if (Num3 > max)
{
    max = Num3;
}

Console.WriteLine($"Наибольшее из введённых чисел = {max}");