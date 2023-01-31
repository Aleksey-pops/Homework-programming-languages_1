// ###  Найти максимальное из трех чисел
Console.WriteLine("Найти максимальное из трех чисел!");

Console.WriteLine("Введите 1 число: ");
int First = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int Second = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 1 число: ");
int True = int.Parse(Console.ReadLine());

int max = First;

if (First > Second) max = First;
if (Second > max) max = Second;
if (True > max) max = True;

Console.Write("Максимальное число из трех равно: ");
Console.WriteLine(max);
