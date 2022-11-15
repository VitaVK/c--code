// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите числа в терминале: ");
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
Console.WriteLine($"{number1 } -> {number2}");
int firstNumber = int.Parse(number1);
int secondNumber = int.Parse(number2);
if (secondNumber/firstNumber==firstNumber)
{
    Console.WriteLine($"{secondNumber} является квадратом  {firstNumber}");
}
else
{
    Console.WriteLine($"{secondNumber} не является квадратом  {firstNumber}");
}