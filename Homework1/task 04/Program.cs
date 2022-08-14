/*
Напишите программу, которая на вход принимает три числа
и выдаёт максимальное из этих чисел
*/

Console.WriteLine("Введите первое число:");
int userNum1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число:");
int userNum2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите третье число:");
int userNum3 = Convert.ToInt32(Console.ReadLine()); 

int Max = userNum1;
if (userNum2 > Max) Max = userNum2;
if (userNum3 > Max) Max = userNum3;

Console.WriteLine($"Максимальным из введённых чисел является {Max}");