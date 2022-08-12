/*
Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void GetCoordinate (int quoter)
{
if (quoter == 1) 
    {
        Console.WriteLine("x > 0 и y > 0");
    }
    else if (quoter == 2) 
    {
        Console.WriteLine("x < 0 и y > 0");
    }
     else if (quoter == 3) 
    {
        Console.WriteLine("x < 0 и y < 0");
    } 
    else if (quoter == 4) 
    {
        Console.WriteLine("x > 0 и y < 0");
    }
    else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ОШИБКА! Введено неверное число");
        Console.ResetColor();
    }
}

Console.WriteLine("Введите число от 0 до 4: ");
int quoterNum = Convert.ToInt32(Console.ReadLine());
GetCoordinate(quoterNum);
