// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(100, 1000);
    
}

void PrintArray (int [] array)
{
    foreach (var item in array)
        System.Console.Write($"{item} ");
        System.Console.WriteLine();
}

void OddNumbers (int [] array)
{
    int OddSum = 0;
    foreach (var item in array)
        if(item % 2 != 0)
        {
            OddSum += item;
        }
    System.Console.WriteLine($"Sum of odd numbers: {OddSum}");
}

Console.Clear();
Console.WriteLine("Enter length array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
OddNumbers(array);