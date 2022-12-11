// See https://aka.ms/new-console-template for more information
Console.WriteLine("Заполнение матрицы по спирали");
string[,] array = fillArray();
PrintArray(array);

string[,] fillArray()
{
  int n = 4;
  string[,] matrix = new string[n, n];

  int temp = 1;
  int i = 0;
  int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
  if(temp < 10)
  matrix[i, j] = "0" + temp;
  else
  matrix[i, j] = "" + temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;

}
 return matrix;
}

void PrintArray(string[,] array){
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