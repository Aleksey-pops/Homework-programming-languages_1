// 5. Выяснить является ли число чётным.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Ура! Число является четным.");
}
else
{
    Console.WriteLine("Увы! Число не является четным.");
}