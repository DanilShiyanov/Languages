/*
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа
*/

int FindSecond (int Number)
{
    int result = (Number/10) % 10;
    return result;
}

Console.WriteLine("Введите трёхзначное число : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Digit2 = FindSecond (userNumber);
Console.WriteLine($"Второй цифрой числа {userNumber} является {Digit2} ");
