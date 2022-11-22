/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трёхзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
Number = Number % 100;
Number = Number / 10;
Console.WriteLine(Number);
