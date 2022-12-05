//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[] summ = GetColumnSum(rows, columns, -5 , 5); 
PrintAverage(summ, columns);

double[] GetColumnSum(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    double[] summ = new double[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = new Random().Next(minValue, maxValue + 1);
           summ [i] += result[j,i];
        }
         Console.WriteLine();
    }
    Console.WriteLine(String.Join(" " , summ));
     return summ;
}

void PrintAverage(double[] summ, int columns){
    for (int i = 0; i< summ.Length; i++)
            {
                double value = summ[i]/columns;
                Console.WriteLine($"Среднеднее арифметическое {i}-го столбца " +  value); //вывод среднего для колонки
            }
}