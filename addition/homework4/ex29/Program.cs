Console.Clear();
int A = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int B = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int C = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int D = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int E = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int F = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int G = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int H = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int[] array = addToArray(A, B, C, D, E, F, G, H);
Console.WriteLine("Array: " + "[" + string.Join(" ,", array) + "]");
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

int[] addToArray(int A, int B, int C, int D, int E, int F, int G, int H){
 int[] array = new int[8];
 array.SetValue(A, 0);
 array.SetValue(B, 1);
 array.SetValue(C, 2);
 array.SetValue(D, 3);
 array.SetValue(E, 4);
 array.SetValue(F, 5);
 array.SetValue(G, 6);
 array.SetValue(H, 7);
 Array.Sort(array);
 return array;
}
