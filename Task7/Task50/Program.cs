// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.WriteLine("Задайте позицию элемента массива");
Console.WriteLine("Номер строки: ");
int m = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine()) - 1;

int mRnd = new Random().Next(1, 10);
int nRnd = new Random().Next(1, 10);
int maxRnd = new Random().Next(1, 100);
//Console.WriteLine($"{mRnd} , {nRnd} , {maxRnd}");

int[,] array = GetArray(mRnd, nRnd, 0, maxRnd);

PrintArray(array);

if (m >= mRnd || n >= nRnd)
{
    Console.WriteLine($"Элемент на позиции {{{m+1}, {n+1}}} отсутствует");
}
else
{
    Console.WriteLine($"Значение элемента на позиции {{{m+1}, {n+1}}}: {array[m, n]}");
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