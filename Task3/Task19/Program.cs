// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string strNumber = Console.ReadLine();
int[] n = new int[strNumber.Length];

if (strNumber.Length != 5)
{
    Console.WriteLine("Число не пятизначное!");
}
else
{
    for (int i = 0; i < strNumber.Length; i++)
    {
        n[i] = int.Parse(strNumber[i].ToString());
    }
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine($"Число {strNumber} является палиндромом");

    } else {
        Console.WriteLine($"Число {strNumber} не является палиндромом");
    }
}
