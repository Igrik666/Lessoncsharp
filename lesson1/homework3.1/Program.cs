/*Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int Fivenumbers = Convert.ToInt32(Console.ReadLine());
int Firstnumber = Fivenumbers /10000;
int Endnumber = Fivenumbers % 10;
if(Firstnumber == Endnumber)
{
    Fivenumbers = Fivenumbers / 10;
    Fivenumbers = Fivenumbers % 1000;
    Firstnumber = Fivenumbers / 100;
    Endnumber = Fivenumbers % 10;
    if((Firstnumber == Endnumber))
    {Console.WriteLine("Число является палиндромом");}
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не является палиндромом");
}

    


