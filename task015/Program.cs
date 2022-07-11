
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int [10];
int size = array.Length;
Console.Write("[");
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i]);
    if (i +1 != size)
    {
        Console.Write(",");
    }

    if ( i % 2 != 0)
    {
        sum = sum + array[i];
    }
} 
Console.Write("]");
Console.Write(" -> " + sum);