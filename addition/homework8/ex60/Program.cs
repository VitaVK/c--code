Console.Clear();
Console.WriteLine("Задайте размер трёхмерного массива ");
Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] ThreeDarray = produce3Darray(x, y, z, 10, 100);

int[,,] produce3Darray(int x1, int y1, int z1, int min, int max)
{
    int[,,] threeDarray = new int[x, y, z];
    for (int x = 0; x < x1; x++)
    {
        for (int y = 0; y < y1; y++)
        {
           for (int z = 0; z < z1; z++)
           {
             threeDarray[x, y, z] = new Random().Next(min, max);
             Console.Write($"{threeDarray[x, y, z], 1} " + "(" + x + "," + y + "," + z + ")" + "\t");
           }
           Console.WriteLine();
        }
        Console.WriteLine();
    }
    return threeDarray;
}
