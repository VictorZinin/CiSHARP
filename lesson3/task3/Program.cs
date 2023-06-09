// Программа на вход получает число и выдает количесто цифр

Console.Clear();
int DoubleToInt(decimal number)
{
    if (number < 1)
    {
        number++;
        while(number % 1 != 0)
        {
            number *= 10;
        }
    }
    else
    {
        while(number % 1 != 0)
        {
            number *= 10;
        }
    }
    return Convert.ToInt32(number);
}
int CountDigitalNumber(int number)
{
    int count = 0;
    if (number == 0)
    {
        count = 1;
    }
    else
    {
        while(number != 0)
         {
             number /= 10;
             count++;
         }
    }
    return count;
}
Console.WriteLine("Enter number");
decimal number = Convert.ToDecimal(Console.ReadLine());
int result = DoubleToInt(number);
System.Console.WriteLine($"Number of digits is: {CountDigitalNumber(result)}");