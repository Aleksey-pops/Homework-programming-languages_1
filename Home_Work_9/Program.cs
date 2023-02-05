// 9. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// for (int i = 10; i <= 99; i++)
// {
//     // Console.WriteLine(i);
//     Console.WriteLine("Число от 10 до 99: " + (i));
//     int first = i / 10;
//     int second = i % 10;
//     if (first > second)
//         {   
//             Console.WriteLine("Первое число больше второго: " + (first));
//         }
//         else
//         {
//             Console.WriteLine("Второе число больше первого: " + (i % 10));
//         }
// }


// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа. Через рандомное число.


Random rnd = new Random();
int i = rnd.Next(10,100);
    Console.WriteLine("Рандомное число от 10 до 99: " + "Это число: " + (i));
    int first = i / 10;
    int second = i % 10;
    if (first > second)
      {   
        Console.WriteLine("Первое число больше второго: " + (first));
        }
    else
    {
        Console.WriteLine("Второе число больше первого: " + (i % 10));
    }