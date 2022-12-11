Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 5, 15);
PrintArray(array);
int[,] sortedArray = sortArrayColumns(array);
PrintArray(sortedArray);

int[,] sortArrayColumns(int[,]array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++) 
        {
            int temp = array[i, j];
            if (array[i,j] <array[i, j + 1])
            {
                array[i, j] =array[i, j + 1];
                array[i, j + 1] =temp;
            }

        }
    }
    return array;
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
