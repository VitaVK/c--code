// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число!");
String number = Console.ReadLine();
bool result = true;

for(int first = 0, last = number.Length -1;first<last ; ++first, --last)
{
    if(number[first] != number[last])
    {
        result = false;
    } 
  
}

if(result==false)
{
   Console.WriteLine("Число не является палиндромом!");
}
else
{
    Console.WriteLine("Число является палиндромом!");
}



