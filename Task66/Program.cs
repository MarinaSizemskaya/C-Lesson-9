// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
int summa = SumFromMToN(m, n);
WriteLine(summa);

int SumFromMToN (int x, int y)
{
    int sum = 0;
    for (int i = x; i <= y; i++)
    {
        sum = sum+i;
    }
    return sum;
}
