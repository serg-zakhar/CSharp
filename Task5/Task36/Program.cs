// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон значений, от: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон значений, до: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
Console.WriteLine($"[{String.Join(", ", array)}]");

int sum = 0;
for (int i = 0; i < size; i += 2)
{
    sum += array[i];
}

Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");


int[] CreateRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}