// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

Console.Clear();
int[] array = CreateRandomArray(8, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] CreateRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}