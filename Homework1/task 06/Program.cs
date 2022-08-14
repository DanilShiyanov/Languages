/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
*/

Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum % 2 == 0)
{
    Console.WriteLine($"Число {userNum} является чётным");
}
else
{
    Console.WriteLine($"Число {userNum} является нечётным");
}