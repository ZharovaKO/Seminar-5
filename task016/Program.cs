// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double [] array = new double [10];
int size = array.Length;
Console.Write("[");
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i]);
    if (i +1 != size)
    {
        Console.Write(", ");
    }
} 
double maxNumber = array[0];
double minNumber = array[0];
for (int i = 0; i < size; i++)
{
    if ( maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if ( minNumber > array[i])
    {
        minNumber = array[i];
    }
}
double result = maxNumber - minNumber;
Console.Write("]");
Console.Write(" -> " + result);