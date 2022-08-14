/*
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет
*/

int FindThird (int Number)
{
    while (Number >= 1000)
    {
        Number = Number/10; 
    }
    int result = Number % 10;
    return result;
}

Console.WriteLine("Введите число : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100)
{
    Console.WriteLine("В введённом числе нет третьей цифры");
}
else 
{
    int Digit3 = FindThird(userNumber);
Console.WriteLine($"Третьей цифрой числа {userNumber} является {Digit3}");
}