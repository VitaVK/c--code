Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = PrintSumm(m, n);
Console.WriteLine("Сумма чисел в диапазоне от M до N =:" + summ);
int PrintSumm(int m, int n)
{
    if(m < n)
    {
       return (m == n) ? n : m + PrintSumm( m + 1, n);
    }
   return (n == m) ? m : n + PrintSumm( n + 1, m);
}
