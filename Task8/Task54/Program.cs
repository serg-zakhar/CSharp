// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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
Console.WriteLine();
SortReverseArray(array);
PrintArray(array);

void SortReverseArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = j + 1; k < col; k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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


// int[] array = { 1, 2, 3, 4, 5, 6 };
// SortReverseArray(array);

// PrintArray(array);

// void SortReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         for (int j = 0; j < array.Length - 1; j++)
//             if (array[j] < array[j + 1])
//             {
//                 int temp = array[j + 1];
//                 array[j + 1] = array[j];
//                 array[j] = temp;
//             }
// }

// void PrintArray(int[] array)
// {
//     foreach (int i in array)
//     {
//         Console.Write($"{i}, ");
//     }
// }