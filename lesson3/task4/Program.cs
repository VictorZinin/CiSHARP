//Программа генерирует массив из 8 0 и 1

Console.Clear();
int [] array = new int [8];
    for (int i = 0; i <8; i++)
    array [i] = new Random().Next(0,2);
    System.Console.Write("Generated array of 0 and 1 : ");
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
