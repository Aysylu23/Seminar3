/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

int number = ReadInt("Введите чило: ");
int i = 1;

while(i <= number)
{
    int sqr = i * i;

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