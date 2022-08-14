/*
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом
*/

Console.WriteLine("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Digit1 = userNumber/10000 ;
int Digit2 = (userNumber/1000) % 10;
int Digit4 = (userNumber%100) / 10;
int Digit5 = userNumber%10;

if (Digit1 == Digit5 && Digit2 == Digit4)
{
    Console.WriteLine($"Число {userNumber} является палиндромом");
}
else
{
    Console.WriteLine($"Число {userNumber} НЕ является палиндромом");
}