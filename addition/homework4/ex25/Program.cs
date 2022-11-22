Console.Clear();
double A = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
double B = GetNumberFromUser("Введите целое число B: ","Ошибка ввода!");
double degree = countDegree(A, B);
Console.WriteLine($"{A} -> {degree}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
double GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if(isCorrect)
        return userNumber;
        
        Console.WriteLine(errorMessage);
    }
}

double countDegree(double firstNumber, double secondNumber){
    double result = 1;
      if(secondNumber == 0)
      {
        return result;
      }
      else if(secondNumber >= 0)
      {
        for(int i = 1; i<=secondNumber; i++)
        {
            result*=firstNumber;
         
        }
      } 
      else 
      {
        secondNumber = -secondNumber;
       for(int i = 1; i<=secondNumber; i++)
        {
          result*=1/firstNumber;
         
        }
      }
      return result;
}
