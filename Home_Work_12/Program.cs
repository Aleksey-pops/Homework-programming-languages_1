// 12. ***Найти третью цифру числа или сообщить, что её нет***

Console.WriteLine("Введите число:" ?? "0");
int num2 = int.Parse(Console.ReadLine());
while (num2 < 100)
{
    Console.WriteLine("Третья цифра отсутсвует в числе!");
    break;
} 

    for (;num2 >= 1000 || num2 <100; num2 = num2 / 10)   
{

}
    Console.WriteLine($"Третья цифра числа " + (num2 % 10));  
 