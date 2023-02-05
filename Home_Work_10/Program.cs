// Удалить вторую цифру трёхзначного числа.


Console.WriteLine("Введите трехзначное число:" ?? "0");
int num3 = int.Parse(Console.ReadLine());

if (num3 <1000 && num3 >99)
{
    
    Console.WriteLine("Третья цифра трехзначного числа: " + (num3 % 10)); int three = num3 % 10;
    // Console.WriteLine(three);
    num3 = (num3 / 10);
    Console.WriteLine("Вторая цифра трехзначного числа: " + (num3 % 10));
    num3 = (num3 / 10);
    Console.WriteLine("Первая цифра трехзначного числа: " + (num3 % 10)); int first = num3 % 10;

    Console.WriteLine("Трехзначное число без после удаления среднего числа: " + (first * 10 + three));
}
else
{
    Console.WriteLine("Неправильная цифра");
}

