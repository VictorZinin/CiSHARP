//программа получает на вход чилса A и B и проверяет является ли A квадратом B

System.Console.WriteLine("Enter an integer A");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter an integer B");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberB * numberB;
System.Console.Write("check result:");
if (numberA == result)
{
    System.Console.Write(" A is the square of b!");
}
else 
{
    System.Console.WriteLine(" A is not the square of b");
}