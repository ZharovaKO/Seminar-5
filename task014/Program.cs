﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int [10];
int size = array.Length;
int count = 0;
Console.Write("[");
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i]);
    if (i +1 != size)
    {
        Console.Write(",");
    }

    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
} 
Console.Write("]");
Console.Write(" -> " + count);