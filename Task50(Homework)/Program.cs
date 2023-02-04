// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
double[] array = AverageColumns(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(array);


double[] AverageColumns(int[,] arr)
{
    double[] mass = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            summ += arr[j, i];//summ = summ + arr[j,i]

        }
        double res = summ / arr.GetLength(0);
        double res2 = Math.Round(res, 1, MidpointRounding.ToZero);
        mass[i] = res2;
    }

    return mass;
}

void PrintArray(double[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(")");
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];///  0,1,
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)//цикл проходит по строкам// чтобы пройтись по столбцам нужно поменять цикли и i и j
    {
        for (int j = 0; j < matrix.GetLength(1); j++)/// циул проходит по столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");// 4--- это форматирование для вывода массива
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}