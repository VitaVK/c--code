Console.WriteLine("Введите  b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
countCoordinates(b1, k1, b2, k2);

void countCoordinates(double b1, double k1, double b2, double k2){
   if ((k1 == k2) && (b1 == b2))
   {
    Console.WriteLine("Прямые совпадают");
   } 
   else if(k1==k2)
   {
    Console.WriteLine("Прямые параллельны");
   }
   else
   {
    double x = (b2-b1)/(k1-k2);
    Console.WriteLine("x = " + x);
    double y = k1*x + b1;
    Console.WriteLine("y = " + y);
    double[] array = {x, y};
    Console.WriteLine("Координаты пересечения прямых -> (" + String.Join("; " , array) + ")");
    }
}
