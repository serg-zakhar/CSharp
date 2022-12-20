Console.WriteLine("Введите номер дня недели (понедельник - 1):");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1) Console.WriteLine("Введите корректное число (от 1 до 7)");
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Сегодня выходной!");
    }
    else
    {
        Console.WriteLine("Сегодня рабочий день((");
    }
}