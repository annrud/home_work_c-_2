Console.Clear();
Console.WriteLine("Программа выводит третью цифру заданного числа.");
Console.Write("Введите целое число: ");

string digit = Console.ReadLine()!;

if (digit.Length < 3)
    Console.WriteLine("Третьей цифры нет");    
else
    Console.WriteLine(digit[2]);

    