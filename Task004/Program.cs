// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
while (N > 0)
{
    int a = N % 10;
    sum = sum + a;
    N = N / 10;
}
Console.WriteLine("Сумма цифр в числе равна " + sum);


