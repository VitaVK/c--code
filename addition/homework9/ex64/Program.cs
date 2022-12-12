Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
printNumbers(n, i);
void printNumbers(int n, int i){
if(n > 1)
      printNumbers(n - 1, i + 1);
Console.Write(i==1 ? i + " " : i + ", ");
}
