/*Задача 17*/
/*Console.Write("Введите координату X: ");
string inputX = Console.ReadLine();
int x = int.Parse(inputX);

Console.Write("Введите координату Y: ");
string inputY = Console.ReadLine();
int y = int.Parse(inputY);

if(x == 0 || y == 0)
{
    Console.WriteLine("X и Y не могут быть равны нулю");
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Четверть 1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Четверть 2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Четверть 3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Четверть 4");
    }
}*/



int x = ReadInt("Введите координату X: ");
int y = ReadInt("Введите координату Y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("X и Y не могут быть равны нулю");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Четверть 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Четверть 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Четверть 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четверть 4");
}

int ReadInt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}