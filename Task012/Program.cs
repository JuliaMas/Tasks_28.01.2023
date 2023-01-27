// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int [] array = new int[10];
int n = array.Length;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
}
foreach (int j in array)
{
    Console.WriteLine(j);
}
Console.WriteLine();
for (int i = 0; i < n/2; i++)
{
	int mult = (array[i] * array[n-1-i]);
	Console.WriteLine(array[i] + " x " + array [n-1-i] + " = " + mult);
}