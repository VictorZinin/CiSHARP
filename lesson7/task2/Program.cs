// Программа показывает, есть ли число введеное пользователем в заданном массиве

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
            System.Console.Write($"{array[m,n],-3}  ");// благодаря -4 выравнил по левому краю
    System.Console.WriteLine();
    }
}
void PrintNum(int [,] array)
{
    string result = "There is not such number in the array";
    System.Console.Write("What number do you need? ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] == num)
            {
                result = ($"Position in array: row- {i+1} col- {j+1}");//покажет номер строки и столбца
                System.Console.WriteLine(result);
                break;
            }
    }
}

Console.Clear();
System.Console.Write("First set the size of the array. Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];

FillArray(array);
PrintArray(array);
PrintNum(array);
