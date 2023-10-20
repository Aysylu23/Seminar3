/*18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/
Console.Write("Введите четверть ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number == 1)
{
    Console.WriteLine("Диапазон координат x > 0, y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Диапазон координат x < 0, y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Диапазон координат x < 0, y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Диапазон координат x > 0, y < 0");
}



/*int number = ReadInt("Введите число: ");

switch (number)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Такой четверти не существует!");
        break;
}

int ReadInt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}*/