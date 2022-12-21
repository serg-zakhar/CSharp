// Генерируются два случайных целых числа a и b  в интервале [10 – 30]. 
// Если a > b,  выводится их разность, eсли a < b,  выводится сумма,  eсли a == b,  
// выводится сообщение “числа равны”.

Random rnd = new Random();
int a = rnd.Next(10, 30);
int b = rnd.Next(10, 30);
if (a > b)
{
    Console.WriteLine($"Разность чисел {a} и {b} равна: {a - b}");
}
else if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine($"Сумма чисел {a} и {b} равна: {a + b}");
}
