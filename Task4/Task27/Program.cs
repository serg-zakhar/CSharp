// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} = {SumNumbers(num)}");

int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num /= 10;
    }
    return sum;
}