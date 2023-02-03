// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int result = SearchMax(array) - SearchMin(array);
Console.WriteLine($"Разница между максимальным и минимальным значением массива: {result}");


int SearchMin(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int SearchMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int[] CreateRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}