// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.Clear();
Console.WriteLine("Задайте размерность и диапазон значений массива");
Console.WriteLine("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = GetDoubleArray(m, n, min, max);
PrintDoubleArray(array);

double[,] GetDoubleArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
            result[i, j] = Math.Round(result[i, j], 2);
        }
    }
    return result;
}

void PrintDoubleArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}