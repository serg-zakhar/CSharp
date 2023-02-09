// Напишите программу, которая заполнит спирально массив 4 на 4. 

Console.Clear();
Console.WriteLine("Задайте размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;

int[,] array = new int[n, m];


int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChange = 0;
int gran = n;

for (int i = 0; i < array.Length; i++)
{
    array[row, col] = i + 1;
    if (--gran == 0)
    {
        gran = m * (dirChange % 2) + n * ((dirChange + 1) % 2) - (dirChange / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChange++;
    }
    col += dx;
    row += dy;
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
