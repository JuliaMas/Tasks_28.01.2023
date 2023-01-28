//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int a = 10; //начало отрезка
int b = 99; // конец отрезка
int countNum = 0; // количество элементов в отрезке
int[] array = new int[123];

var r = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(a/2, b*2 +1);
}
foreach (int j in array)
{
    Console.Write(j + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (a <= array[i] && array[i] <= b) 
    {
        countNum = countNum + 1;
    }
}
Console.WriteLine("Количество элементов в интервале равно " + countNum);


