// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Выводим чётные числа:");
int i = 1;
while (i <= number)
{
    if(i%2==0){
        Console.WriteLine(i);
    }
  i++;
}
