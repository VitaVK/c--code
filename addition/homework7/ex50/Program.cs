//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите i : ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j : ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, -5 , 5); 
ifValueExistsInArray(array, i, j);
PrintArray(array);

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

void ifValueExistsInArray(int[,] array, int i, int j){
    if (i > array.GetLength(0) && j > array.GetLength(1))
    {
       Console.WriteLine("такого числа нет");
    }
    else
    {
        Console.WriteLine(array.GetValue(i,j));
    }
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