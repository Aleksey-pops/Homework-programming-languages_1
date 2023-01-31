// 2. По заданному номеру дня недели вывести его название
Console.WriteLine("Введите порядковый номер дня недели: ");
int First = int.Parse(Console.ReadLine());

string[] days_of_the_week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",};

Console.WriteLine($"День недели:  {days_of_the_week[First - 1]}");
