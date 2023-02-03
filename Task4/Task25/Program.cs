//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {A} в степени {B} = {Pow(A, B)}");

int Pow(int A, int B)
{
    if (B == 0) return 1;
    int result = A;
    for (int i = 2; i <= B; i++)
    {
        result *= A;
    }
    return result;
}