// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int numPos = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] % 2 == 0) numPos++;
}
Console.WriteLine($"Количество четных чисел в массиве: {numPos}");

int[] CreateRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}