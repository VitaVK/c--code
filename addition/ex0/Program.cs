// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число и нажмите Enter: ");
String userInput = Console.ReadLine();
int number = int.Parse(userInput);
int result = number * number;

Console.WriteLine($"{number} -> {result}");
