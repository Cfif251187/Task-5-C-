﻿/*//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
CreatRundomArray(array);
PrintArray(array);

void CreatRundomArray(int[] array)

{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count++;
}
Console.WriteLine($" В массиве {count} четных чисел");


void PrintArray(int[] array)
{
   
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();
}
*/
/*//Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
int[] CreatRundomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
    return array;
}
void ShowArray (int[] array)
{
    for(int i= 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int oddNumSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    
        if(array[i] % 2 == 0) sum = sum + array[i];
    
    return sum;
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatRundomArray(length);
int oddSum = oddNumSum(myArray);
ShowArray(myArray);
Console.WriteLine("Сумма нечетных элементов:"+ oddSum);*/

/*//Задача 38. Задать массив вещественных чисел. 
//Найти разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
CreatRundomArray(array);
ShowArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;
void CreatRundomArray(double[] array)

{
    for(int i = 0; i <array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}

    for (int j = 0; j < array.Length; j++)
    {
    if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] < min)
        {
            min = array[j];
        }
    }


CreatRundomArray(array);
ShowArray(array);
Console.WriteLine($"Максимальное число = {max}, минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");
*/