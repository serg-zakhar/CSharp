Random rnd = new Random();
double c = rnd.Next(-10, 10);
double d = rnd.Next(-10, 10);
if (c % 2 == 0 && d % 2 == 0)
{
    Console.WriteLine($"Частное чисел {c} и {d} равно: {c / d}");
}
else if (c % 2 != 0 && d % 2 != 0)
{
    Console.WriteLine($"Сумма чисел {c} и {d} равна: {c + d}");
}
else
{
    Console.WriteLine($"Произведение чисел {c} и {d} равно: {c * d}");
}