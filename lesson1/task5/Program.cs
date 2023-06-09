// программа на вход получает целое число N и выводит все целые числа от -N до N

Console.WriteLine("Enter interger N:");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while (count < N)
{
    System.Console.Write(count+ " ");
    count++;
} 
