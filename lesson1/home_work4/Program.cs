/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

int N = new int ();
Console.WriteLine("Введите проверочное число");
N = Convert.ToInt32(Console.ReadLine());
int startnumber = 0;
while(startnumber < N - 1)
{startnumber += 2;
Console.WriteLine(startnumber);
}        

