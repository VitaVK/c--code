// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число!");
int number = int.Parse(Console.ReadLine());
int i = 1;
while (i <= number)
{
    Console.WriteLine(Math. Pow(i, 3));
    i++;
}
