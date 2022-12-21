// Генерируется случайное целое число n  в интервале  [ 20 – 99 ]. 
// Проверяется, делится ли оно на введенное с клавиатуры  целое  число d 
// (используйте тернарный оператор).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int rnd = new Random().Next(20, 100);
string msg = (rnd % number == 0) ? $"Число {rnd} делится на {number}"
                             : $"Число {rnd} не делится на {number}";
Console.WriteLine(msg);

