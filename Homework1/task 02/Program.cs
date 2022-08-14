/*
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/

Console.WriteLine("Введите первое число: ");
int userNum1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int userNum2 = Convert.ToInt32(Console.ReadLine());

if (userNum1 > userNum2)
{
    Console.WriteLine($" Большее число - {userNum1}, меньшее число - {userNum2}");
}
else 
{
    Console.WriteLine($" Большее число - {userNum2}, меньшее число - {userNum1}");
}