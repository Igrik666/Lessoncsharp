/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] matrix = new int[8];
Console.Write("[");

for(int ind = 0; ind <= 7; ind++)
{
   matrix [ind] = new Random().Next(0, 99);
Console.Write($"{matrix[ind]}, " );
}
Console.Write("]");