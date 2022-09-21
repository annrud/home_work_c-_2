Console.Clear();
Console.WriteLine(
    "Программа принимает цифру, обозначающую день недели, " +
    "и проверяет, является ли этот день выходным."
    );
Console.Write("Введите номер дня недели (от 1 до 7): ");
int number = int.Parse(Console.ReadLine()!);

while (number < 1 || number > 7)
{
    Console.WriteLine("Вы ввели не правильную цифру.");
    Console.Write("Введите номер дня недели (от 1 до 7): ");
    number = int.Parse(Console.ReadLine()!);
}
if (number > 5)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
        