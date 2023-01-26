// Показать кубы чисел, заканчивающихся на четную цифру
var r = new Random();
int count = 13;
int[]array = new int[count]; 

for(int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(1, 20);
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
for (int i = 0; i < array.Length; i++)
{
    if((array[i] % 2) == 0)
    {
        int mult = array[i]*array[i]*array[i];
        Console.WriteLine("куб числа " + array[i] + " равен " + mult);
    }
}
