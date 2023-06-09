// Программа на вход получает число в 10 системе, выдает его 16 системе.

Console.Clear();
Console.WriteLine("Enter integer");
int num = Convert.ToInt32(Console.ReadLine());
int remaider = 0;
while (num > 16)
{
    remaider = num % 16;
    switch(remaider)
    {
        case 10:
        {
            System.Console.WriteLine("A");
            break;
        }
         case 11:
        {
            System.Console.WriteLine("B");
            break;
        }
         case 12:
        {
            System.Console.WriteLine("C");
            break;
        }
         case 13:
        {
            System.Console.WriteLine("D");
            break;
        }
        case 14:
        {
            System.Console.WriteLine("E");
            break;
        }
        case 15:
        {
            System.Console.WriteLine("F");
            break;
        }
        default:
        {
            System.Console.WriteLine(remaider);
            break;
        }
    }
    num = num / 16;

}
    switch(num)
    {
        case 10:
        {
            System.Console.WriteLine("A");
            break;
        }
         case 11:
        {
            System.Console.WriteLine("B");
            break;
        }
         case 12:
        {
            System.Console.WriteLine("C");
            break;
        }
         case 13:
        {
            System.Console.WriteLine("D");
            break;
        }
        case 14:
        {
            System.Console.WriteLine("E");
            break;
        }
        case 15:
        {
            System.Console.WriteLine("F");
            break;
        }
        default:
        {
            System.Console.WriteLine(num);
            break;
        }
    }

