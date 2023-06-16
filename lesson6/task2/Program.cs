// Программа принмает значения m, n и выдает массив Amn = m+n.

Console.Clear();
void FillArray ( int [,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
        for(int m = 0; m < array.GetLength(1); m++)
            array[n,m] = n + m;
}
void PrintArray ( int [,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for(int m = 0; m < array.GetLength(1); m++)
            System.Console.Write($"{array[n,m],3}  ");//цифра 3 резервирует по 3 символа в ячейке.
    System.Console.WriteLine();
    }
}

System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];

FillArray(array);
PrintArray(array);



