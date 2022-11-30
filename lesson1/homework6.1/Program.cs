/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Пожалуйста, введите число символизирующее количество задаваемых вами чисел: ");
int NumbersUser = Convert.ToInt32(Console.ReadLine());
int[] array = new int[NumbersUser];

for (int i = 0; i < NumbersUser; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int NumbersGreaterZero(int[] array)
{
    int numbersGreaterZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            numbersGreaterZero++;
        }
    }
    return numbersGreaterZero;
}

int numbersGreaterZero = NumbersGreaterZero(array);
Console.WriteLine($"Количество чисел больше 0 = {numbersGreaterZero}");