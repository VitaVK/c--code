// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize, 100, 1000);
Console.WriteLine(String.Join(" " , array));
Console.WriteLine("Колличество чётных чисел в массиве: " + countEvenNumbers(array));
int[] GetArray(int size, int minValue, int maxValue)
{
   int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int countEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        count += 1;
    }
    return count;
}