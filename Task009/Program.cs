// Определить, присутствует ли в заданном массиве, некоторое число
Console.Write("Введите искомое число ");
int number = int.Parse(Console.ReadLine());
int[] array = {10, 93, 48, 46, 77, 48, 92, 14, 76};
int n = array.Length;
int i = 0;
while (i < n)
{
    if(array[i] == number)
    {
        Console.WriteLine("Искомое число присутствует в массиве");
        break;
    }
    i++;
}