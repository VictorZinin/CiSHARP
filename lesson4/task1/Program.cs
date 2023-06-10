// программа выводит массив заданной пользователем размерности и заполняет рандомными числами от [-9;9].
// выдает сумму положительных и отрицательных чисел массива.

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-9, 10);
    
}

void PrintArray (int [] array)
{
    foreach (var item in array)
        System.Console.Write($"{item} ");
        System.Console.WriteLine();
}

void FindSums (int [] array)
{
    int PositiveSum = 0;
    int NegativeSum = 0;
    foreach (var item in array)
        if(item > 0)
        {
            PositiveSum += item;
        }
        else if (item < 0)
        {
            NegativeSum += item;
        }    
    System.Console.WriteLine($"sum positive numbers: {PositiveSum}");
    System.Console.WriteLine($"sum negaitive numbers: {NegativeSum}");
}

Console.Clear();
Console.WriteLine("Enter length array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
FindSums(array);