/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
*/

Console.WriteLine("Введите 3 координаты точки A");
int dotAx = Convert.ToInt32(Console.ReadLine());
int dotAy = Convert.ToInt32(Console.ReadLine());
int dotAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 координаты точки B");
int dotBx = Convert.ToInt32(Console.ReadLine());
int dotBy = Convert.ToInt32(Console.ReadLine());
int dotBz = Convert.ToInt32(Console.ReadLine());

double Distance = Math.Sqrt( (dotBx - dotAx)*(dotBx - dotAx) + (dotBy - dotAy)*(dotBy - dotAy) + (dotBz - dotAz)*(dotBz - dotAz) );
Console.WriteLine($"Расстояние между точками A с координатами ({dotAx},{dotAy},{dotAz}) и B с координатами ({dotBx},{dotBy},{dotBz}) равно {Distance}");
