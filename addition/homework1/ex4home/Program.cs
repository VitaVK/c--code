// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());
int max = 0;

if(firstNumber > secondNumber && firstNumber > thirdNumber){
    max = firstNumber;
} else if (secondNumber > firstNumber && secondNumber > thirdNumber){
    max = secondNumber;
} else{
    max = thirdNumber;
}
Console.WriteLine($" Максимальное число =gi {max}");