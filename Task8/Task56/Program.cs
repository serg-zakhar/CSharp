// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Задайте размерность и диапазон значений массива");
Console.WriteLine("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(row, col, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"Строка {GetMinSumRow(array)} имеет минимальную сумму");

int GetMinSumRow(int[,] array)
{
    int sum = 0;
    int resultSum = 0;
    int resultRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        resultSum = resultSum + array[0, i];
        resultRow = 1;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < resultSum)
        {
            resultSum = sum;
            resultRow = i + 1;
        }
    }
    return resultRow;
}

int[,] CreateRandomArray(int row, int col, int minValue, int maxValue)
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