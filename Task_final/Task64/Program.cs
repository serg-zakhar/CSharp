// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();
Console.WriteLine("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

string PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        return $"{PrintNaturalNumbers(m + 1, n)} " + $"{m}";
    }
    else
    {
        return String.Empty;

    }

}

Console.WriteLine($"Натуральные числа от 1 до {n}: \"{PrintNaturalNumbers(m, n)}\"");
