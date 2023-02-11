// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Задайте 1е число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте 2е число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int M, int N)
{
    if (N == M)
    {
        return M;
    }
    else
    {
        return N + SumNaturalNumbers(M, N - 1);
    }
}

Console.WriteLine($"Сумма всех натуральных чисел от {M} до {N} равна {SumNaturalNumbers(M, N)}");
