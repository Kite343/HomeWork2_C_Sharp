/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// вариант 1
// Console.WriteLine("Введите трёх значное число");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(num / 10 % 10);

// вариант 2
Console.WriteLine("Введите трёх значное число");
string num = Console.ReadLine();
Console.WriteLine(num[1]);