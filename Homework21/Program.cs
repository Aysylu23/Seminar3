/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3д пространстве
А(3,6,8);B(2,1,-7) ->15,84
A(7,-5,0);B(1,-1,9) ->11,53*/
 
int aX = ReadInt("Введите координату X точки A: ");
int aY = ReadInt("Введите координату Y точки A: ");
int aZ = ReadInt("Введите координату Z точки A: ");
int bX = ReadInt("Введите координату X точки B: ");
int bY = ReadInt("Введите координату Y точки B: ");
int bZ = ReadInt("Введите координату Z точки B: ");

double legX = bX - aX;
double legY = bY - aY;
double legZ = bZ - aZ;
double sqrLegX = legX * legX;
double sqrLegY = legY * legY;
double sqrLegZ = legZ * legZ;
double result = Math.Sqrt(sqrLegX + sqrLegY + sqrLegZ );

Console.WriteLine($"Расстояние между точками A({aX},{aY},{aZ}) и B({bX},{bY},{bZ}) равно {result}");

int ReadInt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}