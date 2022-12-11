Console.Clear();
Console.Write("Введите количество строк массива A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = GetArray(rowsA, columnsA, 5, 15);
Console.Write("Введите количество строк массива B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] arrayB = GetArray(rowsB, columnsB, 5, 15);
Console.WriteLine("Матрица А");
PrintArray(arrayA);
Console.WriteLine("Матрица В");
PrintArray(arrayB);
multiplyArrays(arrayA, arrayB);

void multiplyArrays(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
   if(arrayA.GetLength(1)==arrayB.GetLength(0)){
     for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayB.GetLength(0); k++)
                {
                    arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
                }
            }
        }
        Console.WriteLine("Результирующая матрица: ");
        PrintArray(arrayC);
   } 
   else
   {
    Console.WriteLine("Умножение матриц невозможно!");
   }

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
    Console.WriteLine("- - - - - - - - - - -");
}
