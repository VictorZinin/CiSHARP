// Программа получает две точки и находит расстояние между ними

Console.Clear();
Console.WriteLine("Enter coordinates of to points");

double Distace(double x1, double x2, double y1, double y2)

{
   double result = Math.Sqrt((x1- y1) * (x1 - y1) + (x2 - y2) * (x2 - y2));
   return result;
}

System.Console.WriteLine("A : ");
System.Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("B : ");
System.Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"The distace is : {Distace(x1, x2, y1, y2)}");