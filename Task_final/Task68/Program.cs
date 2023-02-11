// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Задайте 1е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте 2е число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Оба числа не должны быть отрицательные!");
    return;
}

int AccermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AccermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AccermanFunction(m - 1, AccermanFunction(m, n - 1));
    return AccermanFunction(m, n);
}

Console.WriteLine($"Результат вычисления функции Аккермана: A({m},{n}) = {AccermanFunction(m, n)}");
