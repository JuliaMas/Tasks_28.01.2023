// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
var r = new Random();
int count = 8;
int[]array = new int[count];
for(int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(0,2);
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
