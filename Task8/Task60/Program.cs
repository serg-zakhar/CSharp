// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

Console.Clear();
Console.WriteLine("Задайте размерность 3мерного массива");
Console.WriteLine("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] array = CreateRandom3DArray(row, col, page, 10, 99);
Print3DArray(array);

int[,,] CreateRandom3DArray(int row, int col, int page, int minValue, int maxValue)
{
    int[,,] result = new int[row, col, page];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < page; k++)
            {
                int temp = new Random().Next(minValue, maxValue + 1);
                while (CheckNumber(result, temp))
                {
                    temp = new Random().Next(minValue, maxValue + 1);
                }
                result[i, j, k] = temp;
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool CheckNumber(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num) return true;
            }
        }
    }
    return false;
}
