//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введи трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
string second = n.ToString();
Console.WriteLine(second[1]);