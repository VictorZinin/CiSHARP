//напишите программу которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear();
int num = new Random().Next(10, 100);
System.Console.WriteLine($"A random number was generated: {num}");
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2)
{
    System.Console.WriteLine($"maximum number is : {num1}");
}
else if (num1 < num2)
{
    System.Console.WriteLine($"maximum number is : {num2}");
}
else 
{
    System.Console.WriteLine($"maximum number is : {num1}");
}
