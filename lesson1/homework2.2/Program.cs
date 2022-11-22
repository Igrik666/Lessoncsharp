/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number);
if(Number < 100) 
{
    Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"Третья цифра" {Number[2]});
    }*/
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if(Number <100)
{
    Console.WriteLine("Третьей цифры нет");
}
if(Number > 99 & Number < 1000) 
    {
       Number = Number % 10;
        Console.WriteLine(Number);
    }    
while (Number > 99)
    if(Number > 999)
    {
        Number = Number / 10;  
        Console.WriteLine(Number % 10);        
    }
    
    
     
    