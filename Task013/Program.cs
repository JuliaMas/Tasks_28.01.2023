// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int [] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10,100);
}
foreach (int j in array)
{
    Console.WriteLine(j);
}
int max = array[0];
int min = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine();
Console.WriteLine("максимальное значение " + max);
Console.WriteLine("минимальное значение " + min);
Console.WriteLine();
int result = max - min;
Console.WriteLine("разница между максимальным и минимальным элементом равна " + result);
