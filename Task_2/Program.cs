// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
string third = n.ToString();

if (third.Length > 2)
{
    Console.WriteLine(third[2]);
} 

else
{
    Console.WriteLine("Третьей цифры нет");
}

