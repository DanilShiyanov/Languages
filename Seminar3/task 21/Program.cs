/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

double FindDistance (int x1, int y1, int x2, int y2);
{
    double CalculateX = (x2 - x1)*(x2 - x1);
    double CalculateY = (y2 - y1)*(y2 - y1);
result = Math.Sqrt(CalculateX + CalculateY);
    return result;
}

Console.WriteLine("Введите X для точки А: ");
int userAX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y для точки A: ");
int userAY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X для точки B: ");
int userBX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y для точки B: ");
int userBY = Convert.ToInt32(Console.ReadLine());

double Distance = FindDistance ( userAX, userAY, userBX, userBY);
Console.WriteLine($"Расстояние равно: {Distance} ");