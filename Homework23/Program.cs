/*Напишите программу, котрая на вход принимает на вход число(N) и выдает таблицу кубов чисел от 1 до N
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125.*/

int number = ReadInt("Введите число: ");
int i = 1;

while(i <= number)
{
    int sqr = i * i * i;

    if(i == number)
    {
        Console.Write(sqr + ". ");
        break;
    }

    Console.Write(sqr + ", ");
    i += 1;
}

int ReadInt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}
