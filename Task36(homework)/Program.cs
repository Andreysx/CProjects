
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] array = CreateArrayRndDouble(5, 1, 99);
PrintArrayDouble(array);
Console.Write(" -> ");
double maxElement = GetMaxElement(array);
double minElement = GetMinElement(array);
double result = DifferenceMaxMin(maxElement, minElement);
Console.Write(result);


double DifferenceMaxMin(double max, double min)//mistake может нужен другой метод
{
    double res = 0;
    if (max > min) res = max - min;
    // res = max - min;
    return res;
}

double GetMaxElement(double[] arr)
{
    double max = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];

    }
    return max;
}

double GetMinElement(double[] arr)///проьлема невыводится мин число
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];

    }
    return min;
}





double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;//метод выводит диапазон вещественных чисел
        arr[i] = Math.Round(num, 1);//округление
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}