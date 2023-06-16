// Программа зеркалит числа в созданном массиве 12345 54321.


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

void FillReverseArray (int [] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = array[array.Length - 1 - i];
        array [array.Length - 1 - i] = array[i];
        array [i] = temp;
    }
}

Console.Clear();
Console.WriteLine("Enter length array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
FillReverseArray(array);
PrintArray(array);