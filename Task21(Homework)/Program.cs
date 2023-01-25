//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A, где x1 = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A, где y1 = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A, где z1 = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, где x2 = ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, где y2 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, где z2 = ");
int c1 = Convert.ToInt32(Console.ReadLine());

double range = Distance(a, b, c, a1, b1, c1);
Console.WriteLine(range);

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
    return (dRound);
}