// 7. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число:" ?? "0");
int num2 = int.Parse(Console.ReadLine());
if (num2 <1000 && num2 >99)
{
    Console.WriteLine($"Последняя цифра трехзначного числа: " + (num2 % 10));
}
else
{
    Console.WriteLine("Неправильная цифра");
}
