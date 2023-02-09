// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Задайте размерность и диапазон значений матриц");
Console.WriteLine("Количество строк 1й матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов 1й матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество строк 2й матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов 2й матрицы: ");
int col2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

if (row1 != col2)
{
    Console.WriteLine(@"Для умножения матриц, количество строк 1й матрицы
    должно совпадать с количеством столбцов 2й");
    return;
}

int[,] array1 = CreateRandomArray(row1, col1, minValue, maxValue);
int[,] array2 = CreateRandomArray(row2, col2, minValue, maxValue);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(MultiplyMatrix(array1, array2));

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
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

