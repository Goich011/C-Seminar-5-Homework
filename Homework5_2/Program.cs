// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Напиши количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < size; i++)
    array[i] = new Random().Next(-10, 100);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int j = 1;
int sum = 0;

while (j < size)
{
    sum = sum + array[j];
    j = (j + 2);
}
Console.WriteLine("Сумма чисел на нечётных позициях = " + (sum));
