// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите А: ");
int number = int.Parse(Console.ReadLine() ?? "");
int i;
int result = 1;
for (i = 1; i<= number; i++)
{
      result = result * i;
      
}
Console.WriteLine(result);

