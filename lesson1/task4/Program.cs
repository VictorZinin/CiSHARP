//программа на вход получает порядковый номер недели и выводит день недели

Console.WriteLine("Enter the day of the week:");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        System.Console.WriteLine("It's Monday!");
        break;
    case 2:
        System.Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        System.Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        System.Console.WriteLine("It's Thursday!");
        break;
    case 5:
        System.Console.WriteLine("It's Friday!");
        break;
    case 6:
        System.Console.WriteLine("It's Saturday!");
        break;
    case 7:
        System.Console.WriteLine("It's Sunday!");
        break; 
    default:
        System.Console.WriteLine("You entered the wrong number");
        break;                  
}
