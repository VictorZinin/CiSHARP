// Программа получает на вход число и выводит квадраты всех чисел до него

Console.Clear();
string SqrInLine(double number)
{
    int i = 1;
    int sqr;
    string result = "";
    while (i <= number)
    {
        sqr = i * i;
        result = result + sqr.ToString() + " ";
        i++;
    }
    return result;
}
Console.WriteLine("Enter an integer");
double number = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine(SqrInLine(number));
