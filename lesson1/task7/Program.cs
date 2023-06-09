// программа выдает возможные значения x и y в зависимости от введенного значения четверти

void CheckQuarter(int quarter)
{
    switch(quarter)
    {
        case 1:
        {
            System.Console.WriteLine(" x > 0, y > 0");
            break;
        }
         case 2:
        {
            System.Console.WriteLine(" x < 0, y > 0");
            break;
        }
         case 3:
        {
            System.Console.WriteLine(" x < 0, y < 0");
            break;
        }
         case 4:
        {
            System.Console.WriteLine(" x > 0, y < 0");
            break;
        }
        default:
        {
            System.Console.WriteLine("There is no quarter.");
            break;
        }
    }
}

Console.Clear();
System.Console.WriteLine("Enter a quarter: ");
try
{
    int quarter = Convert.ToInt32(Console.ReadLine());
    CheckQuarter(quarter);
}
catch
{
    System.Console.WriteLine("Error. Enter an integer.");
}