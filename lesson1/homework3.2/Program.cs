/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int GetQuarterFromCoordinate(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void showInformationAboutQuarter(int x, int y, int quarter)
{
    if (quarter != 0)
    {
        Console.WriteLine($"Точка с координатами [{x}:{y}] находиться в {quarter} четверти ");
    }
    else
    {
        Console.WriteLine($"Точка с координатами [{x}:{y}] находиться оси координат ");
    }
}
int x = getNumberFromUser("Введите X:");
int y = getNumberFromUser("Введите Y:");
int quarter = GetQuarterFromCoordinate(x, y);
showInformationAboutQuarter(x, y,quarter);