﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int n = Convert.ToInt32(Console.ReadLine());
  
if ( n == 6 || n == 7 )
{
  Console.WriteLine("да");  
}
else if (n < 1 || n > 7)
{
    Console.WriteLine("Это число не является днем недели");
}
else
{
    Console.WriteLine("нет");
}
