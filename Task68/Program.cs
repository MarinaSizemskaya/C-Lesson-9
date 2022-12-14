// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();

Write("Введите m: ");
int m = int.Parse(ReadLine());
Write("Введите n: ");
int n = int.Parse(ReadLine());

WriteLine(AсkermanFunction(m, n));

int AсkermanFunction(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if (y == 0 && x > 0)
    {
        return AсkermanFunction(x - 1, 1);
    }
    else
    {
        return (AсkermanFunction(x - 1, AсkermanFunction(x, y - 1)));
    }
}