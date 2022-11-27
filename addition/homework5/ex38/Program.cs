// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize, 0, 1000);
Console.WriteLine(String.Join(" " , array));
Console.WriteLine("Разница между минимальным и максимальным числом массива: " + countMaxMinNumDiff(array));
int[] GetArray(int size, int minValue, int maxValue)
{
   int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int countMaxMinNumDiff(int[] array){
    Array.Sort(array);
    Console.WriteLine($"min -> {array[0]}");
    Console.WriteLine($"max -> {array[array.Length - 1]}");
    return array[array.Length - 1] - array[0];
}
