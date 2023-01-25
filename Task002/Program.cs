// Найти сумму чисел от 1 до А

Console.Write("Введите А: ");
int number = int.Parse(Console.ReadLine() ?? "");
/*int i;
int result = 0;
for (i = 1; i<= number; i++)
{
      result = result + i;
      
}*/


int result = (number*(number + 1) / 2);
Console.WriteLine(result);

