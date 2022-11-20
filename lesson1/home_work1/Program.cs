/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int firstnumber = new int ();
Console.WriteLine("Введите первое число");
firstnumber = Convert.ToInt32(Console.ReadLine());
int secondnumber = new int ();
Console.WriteLine("Введите следующее число");
secondnumber = Convert.ToInt32(Console.ReadLine());
if(firstnumber < secondnumber) 
{
    Console.WriteLine(secondnumber);
    }
    else
    {
        Console.WriteLine(firstnumber);
    }