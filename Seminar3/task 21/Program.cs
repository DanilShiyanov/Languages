/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки A");
int dotAx = Convert.ToInt32(Console.ReadLine());
int dotAy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int dotBx = Convert.ToInt32(Console.ReadLine());
int dotBy = Convert.ToInt32(Console.ReadLine());

// квадрат - Math.Pow(значение, 2)
double Distance = Math.Sqrt( (dotBx - dotAx)*(dotBx - dotAx) + (dotBy - dotAy)*(dotBy - dotAy) );
Console.WriteLine($"Расстояние между точками A и B равно {Distance}");