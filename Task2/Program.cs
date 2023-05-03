// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");

int x = Convert.ToBase64CharArray(Console.ReadLine());
int result = x % 10;

if (x / 100 > 0) 
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}