// Найти сумму чисел одномерного массива стоящих на нечетной позиции
var r = new Random();
int count = 13;
int[]array = new int[count]; 
int sum = 0;   //сумма чисел, стоящих на нечётной позиции массива, равна 

for(int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(1, 20);
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        sum = sum +array[i];   
    }
}
Console.WriteLine("сумма чисел, стоящих на нечётной позиции массива, равна  " + sum);
