// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int dayOfWeek = int.Parse(Console.ReadLine());
if(dayOfWeek==6 || dayOfWeek==7){
    Console.WriteLine("Выходной!");
} else {
    Console.WriteLine("Рабочий день!");
}
