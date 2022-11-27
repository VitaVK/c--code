// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize, 0, 1000);
Console.WriteLine(String.Join(" " , array));
Console.WriteLine("Сумма чисел под четными индексами в массиве: " + sumEvenIndexes(array));
int[] GetArray(int size, int minValue, int maxValue)
{
   int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int sumEvenIndexes(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2==0)
        {
        count += array[i];
        Console.WriteLine(array[i]);
        }

    }
    return count;
}
