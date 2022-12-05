//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = GetArray(rows, columns, -5 , 5);
PrintArray(array);

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
     return result;
}

void PrintArray(double[,] array){
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{Math.Round(array[i,j], 2)} " + "\t");
        }
        Console.WriteLine();
    }

}

