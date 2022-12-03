Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = fillArray(arraySize);
Console.WriteLine(String.Join(" " , array));
int sum = countPositivNumbers(array);

int[] fillArray(int arraySize){
    int[] array = new int[arraySize];
    for(int i = 0; i < arraySize; i++){
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int countPositivNumbers(int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0){
            sum++;
        }
    }
    Console.WriteLine("Колличество положительных чисел в массиве: " + sum);
    return sum;
}


