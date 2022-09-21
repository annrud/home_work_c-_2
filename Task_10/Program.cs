Console.Clear();
Console.WriteLine("Программа принимает на вход трёхзначное число и выдаёт вторую цифру этого числа.");
Console.Write("Введите трёхзначное число: ");

int digit = int.Parse(Console.ReadLine()!);

while (digit < 100 || digit > 999)
{
    Console.WriteLine("Вы ввели не трёхзначное число.");
    Console.Write("Введите трёхзначное число: ");
    digit = int.Parse(Console.ReadLine()!);
}

Console.WriteLine(digit / 10 % 10);
