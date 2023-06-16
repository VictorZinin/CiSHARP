// Программа выводит массив заполненный вещественными числами

Console.Clear();
void FillArray ( double [,] array)
{
    Random randNum = new Random();
    for (int m = 0; m < array.GetLength(0); m++)
        for(int n = 0; n < array.GetLength(1); n++)
            array[m,n] = Math.Round(randNum.NextDouble() * (10 - 1) + 1, 1);
}

void PrintArray ( double [,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
            System.Console.Write($"{array[m,n],-3}  ");// благодаря -4 выравнил по левому краю
    System.Console.WriteLine();
    }
}

System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows,cols];

FillArray(array);
PrintArray(array);
