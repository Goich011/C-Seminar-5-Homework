// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[4];
int sum = 0;
for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(100,999);
    if(array[i] % 2 == 0)
        sum = sum + array[i];
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма четных элементов = " + (sum));