//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели (понедельник - 1):");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Сегодня выходной!");
}
else if (number < 6 && number > 0)
{
    Console.WriteLine("Сегодня рабочий день((");
}
else
{
    Console.WriteLine("Введите корректное число (от 1 до 7)");
}
