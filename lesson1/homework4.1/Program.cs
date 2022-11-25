/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число: ");
int Number = new int();
Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int Degree = new int();
Degree = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int Number, int Degree)
{
    int result = 1;
    for (int i = 1; i <= Degree; i++)
    {
        result = result * Number;
    }
    return result;
}
