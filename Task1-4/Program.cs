Console.WriteLine("Введите число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= number)
{
    Console.WriteLine(i);
    i += 2;
}