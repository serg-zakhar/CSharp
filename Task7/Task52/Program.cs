// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
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

int[,] array = GetArray(m, n, min, max);

PrintArray(array);
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Среднее арифметическое {i+1} столбца равно: {GetMidVal(array, i)}");
}


double GetMidVal(int[,] array, int n)
{
    double sum = 0;
    double result = 0;
    //Console.WriteLine(array.GetLength(0));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, n];
        //Console.WriteLine(array[i,n]);
    }
    result = sum / array.GetLength(0);
    return Math.Round(result, 2);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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