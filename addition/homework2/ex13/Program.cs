// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
String number = Console.ReadLine();
if(number.Length < 3)
{
 Console.WriteLine("Третьей цифры нет!");   
} else{
Console.WriteLine(number.Substring(2,1));
}

