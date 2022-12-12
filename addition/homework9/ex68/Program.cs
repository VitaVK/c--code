Console.Write("Введите целое положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 0 || m < 0)
{
    Console.Write("Введите целые положительные числа");
} 
else
{
    Console.WriteLine("AkkermanFunc = " + AkkermanFunc(m, n));
    Console.Write("m = " + m + ",n = " + n + " -> A( " + m + ", " + n + ")");
}

int AkkermanFunc(int m, int n)
{ 
      if (m == 0) return n + 1;
      else if (n == 0) return AkkermanFunc(m - 1, 1);
      else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
