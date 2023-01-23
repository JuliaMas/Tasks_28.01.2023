// Найти сумму чисел от 1 до А

Console.Write("Введите А: ");
int number = int.Parse(Console.ReadLine() ?? "");

int result = (number*(number + 1) / 2);
Console.WriteLine(result);

