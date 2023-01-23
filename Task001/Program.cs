// Найти кубы чисел от 1 до N


Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine());
for(int i = 1; i<=number; i++)
{
    int result = i*i*i;
    Console.WriteLine(result);
}