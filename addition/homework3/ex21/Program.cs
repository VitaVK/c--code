// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координаты точки A!");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B!");
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int y3 = int.Parse(Console.ReadLine());
double result = calculateDistance(x1, x2, x3, y1, y2, y3);
Console.WriteLine(result);


double calculateDistance(int x1, int x2, int x3, int y1, int y2, int y3)
{
 return Math.Sqrt(Math. Pow(y1 - x1, 2) + Math. Pow(y2 - x2, 2) + Math. Pow(y3 - x3, 2));
}

