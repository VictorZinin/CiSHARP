// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 
// И  найти отдельно сумму элементов обратной диагонали.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// Сумма элементов обратной диагонали 8 + 9 + 7 = 24

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-9, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void PrintArray2(int[] array)
{
    foreach (var item in array)
    {
        System.Console.WriteLine($"{item} ");
    }
}

int [] Sum (int[,] array) // создали массив
{
    int [] sum = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[0]+=array[i,i]; // диагональ
            sum[1]+=array[i,array.GetLength(1)-i-1]; // обратная диагональ
        }
    return sum;
}

Console.Clear();
System.Console.Write("Enter number of rows and cols: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = rows;
int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);

PrintArray2(Sum(array));