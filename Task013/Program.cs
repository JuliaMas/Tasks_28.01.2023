// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int [] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
}
foreach (int j in array)
{
    Console.WriteLine(j);
}
int max = 1;
int min = 100;
for (int i = 0; i < array.Length; i++)   
{
    if (array[i]>max) max = array[i]; 
    if(array[i]< min) min=array[i];
}  

Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine();
int result = max - min;
Console.WriteLine(result);


   
   
   // int result = max - min;
    //Console.WriteLine("разница между максимальным и минимальным элементом равна ");

