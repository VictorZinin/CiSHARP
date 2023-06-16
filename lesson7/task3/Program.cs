// Программа находит среднее арифметическое в каждом столбце

void FillArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
}
void PrintArray ( int [,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
            System.Console.Write($"{array[m,n],-3}  ");
    System.Console.WriteLine();
    }
}
void AverageArray(int [,] array)
{
        for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        int count = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
            count++;
        }
    System.Console.WriteLine($"col {j+1} is {result/count}"); 
    }
    
}

Console.Clear();
System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine("Array of a: ");
AverageArray(array);
