/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
14212 -> нет
18564 -> нет
21212 -> да*/

int number = ReadInt("Введите чило: ");



if (number < 10000 || number > 99999)
{ 
    Console.WriteLine("Введите пятизначное число");
    return;
}
else if (number / 10000 == number % 10) 
{
    Console.WriteLine("да");
}

else if (number / 1000 % 10 == number % 100 / 10)
{
    Console.WriteLine("да");
}

else 
{
    Console.WriteLine("нет");
}



int ReadInt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}

if (number < 10000 || number > 99999)
{ 
    Console.WriteLine("Число не пятизначное");
    return false;
}
else if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10) 
{
     Console.WriteLine("");
    return true;
}
else 
{
    Console.WriteLine("");
    return false;
}