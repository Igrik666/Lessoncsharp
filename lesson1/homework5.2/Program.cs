/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GenerateRandomArray (int startPoint, int endPoint,int length)
    {
     int [] Array = new int [length];
        for (int i = 0; i < length; i++)
         {
            Array [i] = new Random().Next(startPoint, endPoint + 1);
         }
            return Array;
    }

int GetSumOfEvenIndex (int [] array)
    {
     int summa = 0;
     for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                 summa = summa + array[i];
            }                
        }
             return summa;
    }
void PrintArray(int [] Array)
    {
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
     {
         Console.Write(Array[i]);
            if (i < Array.Length - 1)
                 {
                    Console.Write(", ");
                }
     }
    Console.WriteLine("]");
    }

int [] ResultArray = GenerateRandomArray (-99, 99, 4);
PrintArray (ResultArray);
int summa = GetSumOfEvenIndex (ResultArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {summa}. ");
Console.ResetColor();




        
    

