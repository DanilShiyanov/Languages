/*
Напишите программу, которая принимает на вход число (N) и выводит таблицу квадратов
чисел от 1 до N
*/

Console.WriteLine("Введите число N: ");
int userNum = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<= userNum; i++)
{
    Console.Write($"{i*i} ");
}