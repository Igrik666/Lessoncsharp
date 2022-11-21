/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

int numberday = new int();
Console.WriteLine("Введите число от 1 до 7 обозначающее день недели");
numberday = Convert.ToInt32(Console.ReadLine());
if(numberday <= 5) {
    Console.WriteLine("Будний день");
}
    else {Console.WriteLine("Выходной день!!!");}
