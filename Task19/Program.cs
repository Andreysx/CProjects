//Задача 20: Напишите программу, 
//которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве(на плоскости).
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7.21

Console.Write("Введите координаты точки A, где x1 = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A, где y1 = ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, где x2 = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B, где y2 = ");
int b1 = Convert.ToInt32(Console.ReadLine());


//double d = Math.Sqrt((a-b)*(a-b)+(a1-b1)*(a1-b1)); РЕШЕНИЕ ЗАДАЧИ БЕЗ МЕТОДА
//double dRound = Math.Round(d,2,MidpointRounding.ToZero); РЕШЕНИЕ ЗАДАЧИ БЕЗ МЕТОДА
//Console.WriteLine(dRound); РЕШЕНИЕ ЗАДАЧИ БЕЗ МЕТОДА
double range = Distance(a, a1, b, b1);
Console.WriteLine(range);


double Distance(int x1, int y1, int x2, int y2)
{
    double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    double dRound = Math.Round(d,2,MidpointRounding.ToZero);
   return(dRound);
}