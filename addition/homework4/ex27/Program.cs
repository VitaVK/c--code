Console.Clear();
int A = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int func = countNumbers(A);
Console.WriteLine($"{A} -> {func}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
        return userNumber;
        
        Console.WriteLine(errorMessage);
    }
}

int countNumbers(int number){
    int result = 0;
    for(int i = 1; i != 0; i++){
        result+=number % 10;
        number/=10;
    }
    return result;
}
