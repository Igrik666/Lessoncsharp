/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int firstnumber = new int ();
Console.WriteLine("Введите первое число");
firstnumber = Convert.ToInt32(Console.ReadLine());
int secondnumber = new int ();
Console.WriteLine("Введите следующее число");
secondnumber = Convert.ToInt32(Console.ReadLine());
int thirdnumber = new int ();
Console.WriteLine("Введите следующее число");
thirdnumber = Convert.ToInt32(Console.ReadLine());
if(firstnumber > secondnumber && firstnumber > thirdnumber) 
{
    Console.WriteLine(firstnumber);
}
if(secondnumber > firstnumber && secondnumber > thirdnumber) 
{
    Console.WriteLine(secondnumber);
}
if(thirdnumber > secondnumber && thirdnumber > firstnumber) 
{
    Console.WriteLine(thirdnumber);
} 
    