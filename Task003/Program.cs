// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
int i;
int result = numberA;
for(i = 1; i<numberB; i++)
{
    result = result * numberA;
}
    Console.WriteLine(result);






