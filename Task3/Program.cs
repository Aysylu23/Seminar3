/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

int ax = 3;
int ay = 6;
int bx = 2;
int by = 1;

double a = Math.Pow(ax - bx, 2);
double b = Math.Pow(ay - by, 2);


double result = Math.Sqrt (a + b);
Console.WriteLine(result);


/*int aX = ReadInt("Введите координату X точки A: ");
int aY = ReadInt("Введите координату Y точки A: ");
int bX = ReadInt("Введите координату X точки B: ");
int bY = ReadInt("Введите координату Y точки B: ");

double legX = bX - aX;
double legY = bY - aY;
double sqrLegX = legX * legX;
double sqrLegY = legY * legY;
double result = Math.Sqrt(sqrLegX + sqrLegY);

Console.WriteLine($"Расстояние между точками A({aX},{aY}) и B({bX},{bY}) равно {result}");

int ReadInt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}*/