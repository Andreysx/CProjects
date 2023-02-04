// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = SearchX(k1, b1, k2, b2);
double y = SearchY(k1, b1, k2, b2);
PrintResult(x, y, k1, b1, k2, b2);

void PrintResult(double inX, double inY, double inK1, double inB1, double inK2, double inB2)
{

    if (inK1 == inK2)
    {
        Console.Write("Прямые не пересекаются");
        return;
    }
    else if (inB1 == inB2)
    {
        Console.Write("Прямые параллельны");
        return;
    }
    else
        Console.Write($"b1 = {inB1}, k1 = {inK1}, b2 = {inB2}, k2 = {inK2} -> ({inX}; {inY})");

}


double SearchX(double inK1, double inB1, double inK2, double inB2)
{
    double outResult = (inB2 - inB1) / (inK1 - inK2);
    return Math.Round(outResult, 2, MidpointRounding.ToZero);
}


double SearchY(double inK1, double inB1, double inK2, double inB2)
{
    double outResult = inK1 * x + inB1;
    return Math.Round(outResult, 2, MidpointRounding.ToZero);// ОКРУГЛЕНИЕ,(СТРАТЕГИЯ ОКРУГЛЕНИЯ)
}









// void NumbersReturn(int inK1, int inB1, int inK2, int inB2)
// {

//     x = (inB2 - inB1) / (inK1 - inK2);
//     y = inK1 * x + inB1;
// }
// NumbersReturn(k1, b1, k2, b2);





// y = k1 * x + b1, y = k2 * x + b2;
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x*(k1-k2) = b2-b1
// x = (b2-b1)/(k1-k2)