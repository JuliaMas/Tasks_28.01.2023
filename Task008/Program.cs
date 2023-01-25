// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
var r = new Random();
int count = 13;
int[]array = new int[count]; 
int resultA = 0; // количество четных чисел
int resultB = 0; //количество нечетных чисел
for(int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(100,1000);
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
for(int i = 0; i < array.Length; i++)
{
    if((array[i] % 2) == 0)
    {
        resultA = resultA + 1;
    }
    else
    {
        resultB = resultB + 1;
    }

}
Console.WriteLine("количество чётных чисел равно " + resultA);
Console.WriteLine("количество нечётных чисел равно " + resultB);