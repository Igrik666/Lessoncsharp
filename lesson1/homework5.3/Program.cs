/*Задача 38: Задайте массив вещественных чисел. Найдите разницу
 между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double [] GenerateRandomArray (int startPoint, int endPoint, int  length)
    {
     double  [] Array = new double [length];
        for (int i = 0; i < length; i++)
         {
            Array [i] = new Random().Next(startPoint, endPoint + 1);
         }
            return Array;
    }

double GetMinElementOfArray (double [] Array)
     {
     double min = Array[0];
      for (int i = 0; i < Array.Length; i++)
         {
             if (Array[i] < min)
             {
                 min = Array[i];
             }
         }
      return min;
     }

 double GetMaxElementOfArray (double [] Array)
     {
     double max = Array[0];
      for (int i = 0; i < Array.Length; i++)
         {
             if (Array[i] > max)
             {
                 max = Array[i];
             }
         }
      return max;
     }    

double DifferenceElementOfArray (double max, double min)
    {
    double Difference = max - min;  
    return Difference;
    }

void PrintArray(double [] Array)
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

double [] ResultArray = GenerateRandomArray (-99, 99, 5);
PrintArray (ResultArray);
double min = GetMinElementOfArray (ResultArray);
double max = GetMaxElementOfArray (ResultArray);
double Difference = DifferenceElementOfArray (max, min);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(value: $"Разница между максимальным '{max}' и минимальным элементом массива '{min}' = {Difference}. ");
Console.ResetColor();