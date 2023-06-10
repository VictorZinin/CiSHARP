﻿// Задайте массив вещественных случайных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

void FillArray(double[] collection, double N)
{
    for (int i = 0; i < N; i++)
    {
        collection[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}
double Difference(double[] collection)
{
    double max = collection[0];
    double min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > max)
        {
            max = collection[i];
        }
        else if (collection[i] < min)
        {
            min = collection[i];
        }
    }
    return max - min;
}

Console.Clear();
System.Console.Write("Enter length array: ");
double N = Convert.ToDouble(Console.ReadLine());
double[] array = new double[(int)N];
FillArray(array, N);
System.Console.Write("[");
foreach (double item in array)
{
    System.Console.Write(item + " ");
}
System.Console.Write("]");
System.Console.WriteLine();
System.Console.Write($"Difference between maximum and minimum element: {Difference(array)}");