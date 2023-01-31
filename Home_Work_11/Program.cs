// 11. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите 1 число: ");
double First = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
double Second = double.Parse(Console.ReadLine());

if (First % Second == 0)
{
Console.WriteLine("Ура! Числа является кратными, друг другу.");
}
if (Second % First == 0 && Second / First > 1)
{
Console.WriteLine("Ура! Числа является кратными.");
}
if (First >= Second)Console.WriteLine("Числа не является кратными друг другу. Остаток от деления первого числа на второе: " + First % Second);
if (Second >= First)Console.WriteLine("Числа не является кратными друг другу. Остаток от деления второго числа на первое: " + Second % First);

