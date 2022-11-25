/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int Number = new int();
Number = Convert.ToInt32(Console.ReadLine());
int SummaNumber = 0;

while(Number > 0)
{
    int OneNumber = Number % 10;
    SummaNumber = SummaNumber + OneNumber;
    Number = Number / 10;
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Сумма цифр в числе = {SummaNumber}");
Console.ResetColor();
