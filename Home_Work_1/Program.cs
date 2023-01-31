//  1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите 1 число: ");
int First = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int Second = int.Parse(Console.ReadLine());

int c = (First * First);
if (Second == c )
{
    Console.WriteLine("Ура! Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Увы первое число не является квадратом второго.");

}
