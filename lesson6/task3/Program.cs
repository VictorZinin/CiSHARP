// программа на вход получает размеры двумерного массива.
// Заполняет его рандомными числами и выводит полученный массив.

Console.Clear();
void FillArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
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

System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];

FillArray(array);
PrintArray(array);
