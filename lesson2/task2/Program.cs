// В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
// Напишите программу, в которую пользователь вводит сумму вклада.
// Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200 включительно,  то начисляется 7%.
// Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
// Не вложив деньги, вклад открыть нельзя, поэтому ситуации с отрицательными числами или 0 не рассматриваем.


using System;

public class MainClass
{
    public static void Main()
    {
        Console.Clear();
System.Console.Write("Enter amount you want to deposit into your bank account : ");   
double bankDeposit = Convert.ToDouble(Console.ReadLine());
double sum = 0.0;
if (bankDeposit < 100)
{
    sum = bankDeposit * 1.05;
}
else if ( bankDeposit >= 100 && bankDeposit <= 200)
{
   sum = bankDeposit * 1.07;
}
else
{
    sum = bankDeposit * 1.1;
}
System.Console.WriteLine($"Amount after interest: {sum}");

    }
}