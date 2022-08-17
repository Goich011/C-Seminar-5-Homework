// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Напиши количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int index = 0;

Console.WriteLine("Введи числа в массив: ");

while (index < size)
{
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

if (index != 0)
    index = 0;
int max_index = 0;
int min_index = 0;

while (index < size)
{
    if (array[min_index] > array[index])
        min_index = index;
    if (array[max_index] < array[index])
        max_index = index;
    index++;
}
Console.WriteLine(array[min_index]);
Console.WriteLine(array[max_index]);

Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + (array[max_index] - array[min_index]));
