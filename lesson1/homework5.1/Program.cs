/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

 int[] GenerateRandomArray (int startPoint, int endPoint,int length)
    {
     int [] Array = new int [length];
        for (int i = 0; i < length; i++)
         {
            Array [i] = new Random().Next(startPoint, endPoint + 1);
         }
            return Array;
    }

int GetEvenNumberArray (int [] Array)
    {
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
        {
            if (Array [i] % 2 == 0)
          {
               count++;
          }
        }
             return count;
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

int [] ResultArray = GenerateRandomArray (100, 999, 4);
PrintArray (ResultArray);
int count = GetEvenNumberArray (ResultArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Количество четных чисел в массиве = {count}. ");
Console.ResetColor();




        
    
