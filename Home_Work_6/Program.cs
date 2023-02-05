using System;
// ## 6. Показать четные числа от 1 до N

Console.WriteLine("Введите число N: " ?? "0");
int N = int.Parse(Console.ReadLine());

for (int num = 1; N > num || num % 2 == 0 ;num++)
 if (num % 2 == 0)
{
    Console.WriteLine("Четные числа." + num);
}