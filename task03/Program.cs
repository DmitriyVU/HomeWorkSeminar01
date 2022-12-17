/*Напишите программу, которая на вход принимает число и выдает, является ли число четным
 (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Clear();

Console.Write("Введите любое число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{ Console.WriteLine($"число: {num} - четное"); }
else
{ Console.WriteLine($"Число: {num} - нечетное"); }