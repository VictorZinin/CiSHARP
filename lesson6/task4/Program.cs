// Программа получает размеры массива и выводит заполненый рандомными числами.
// Выводит второй массив с увелличинными вдвое нечетными индексами (1,1 3,3 и т.д).

Console.Clear();
void FillArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-9,10);
}
void PrintArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i,j],3}  ");//цифра 3 резервирует по 3 символа в ячейке.
    System.Console.WriteLine();
    }
}
void ReplaceArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if (i % 2 != 0 && j % 2 != 0)
            array[i,j] = array[i,j]*array[i,j];
}

System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ReplaceArray (array);
PrintArray(array);
