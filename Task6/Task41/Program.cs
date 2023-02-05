// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();
Console.WriteLine("Задайте количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int countPos = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) countPos += 1;
}

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Вы ввели {countPos} положительных чисел");
