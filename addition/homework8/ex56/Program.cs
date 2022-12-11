Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 5, 15);
PrintArray(array);
int[] sum = columnSum(array);
rowOfMaxSum(sum);

void rowOfMaxSum(int[] sum)
{
  int max = 0;
  for(int i = 0; i < sum.Length/2; i++)
  {
      if(sum[i] > max){
         max = sum[i];
      }
  }
  for(int i = 0; i < sum.Length; i++)
  {
    if(sum[i] == max){
        Console.WriteLine("Наибольшая сумма в " + (i + 1) + "м ряду");
    }
  }
}

int[] columnSum(int[,] array){
    int[] sum = new int[array.GetLength(0)];
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             sum [i] += array[i,j];
        }
    }
    return sum;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
     return result;
}

void PrintArray(int[,] array){
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j], 2} " + "\t");
        }
        Console.WriteLine();
    }
}
