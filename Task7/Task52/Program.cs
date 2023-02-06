// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("Задайте размерность и диапазон значений массива");
Console.WriteLine("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(row, col, min, max);

PrintArray(array);
for (int i = 0; i < col; i++)
{
    Console.WriteLine($"Среднее арифметическое {i+1} столбца равно: {GetMidVal(array, i)}");
}


double GetMidVal(int[,] array, int col)
{
    double sum = 0;
    double result = 0;
    //Console.WriteLine(array.GetLength(0));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, col];
        //Console.WriteLine(array[i,col]);
    }
    result = sum / array.GetLength(0);
    return Math.Round(result, 2);
}

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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