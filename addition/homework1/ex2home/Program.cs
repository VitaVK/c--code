// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
 int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
 int secondNumber = int.Parse(Console.ReadLine());
 if(firstNumber > secondNumber){
    Console.WriteLine($" max = {firstNumber}; min = {secondNumber}");
 } else{
    Console.WriteLine($" min = {firstNumber}; max = {secondNumber}");
 }
