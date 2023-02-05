// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Программа выводит координаты точки пересечения двух прямых,");
Console.WriteLine("заданных уравнением y = kx + b");
Console.WriteLine("Введите коэфициенты для первого уравнения");
Console.WriteLine("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициенты для второго уравнения");
Console.WriteLine("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки: {{{x}, {y}}} ");