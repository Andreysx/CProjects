// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//метод задает двумерный массив целых чисел (наш шаблонный)
{
    int[,] matrix = new int[rows, columns];/// 0,1,
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)//цикл проходит по строкам// чтобы пройтись по столбцам нужно поменять цикли и i и j
    {
        for (int j = 0; j < matrix.GetLength(1); j++)/// цикл проходит по столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)//метод распечатывает двумерный массив целых чисел(наш шаблонный)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("||");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");// 4- это форматирование для вывода массива
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("||");
    }

}
double[] AverageColum(int[,] matrix)// метод находит среднее арифметическое в каждом столбце
{
    double[] array = new double[matrix.GetLength(1)];//создаем одномерный массив вещественных чисел и присваиваем ему возвращаемое количество столбцов в нашем двумерном массиве
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;// создаем переменную в которой будем высчитывать сумму элементов в каждом столбце,по умолчанию = 0
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j, i];//находим сумму элементов в стобце

        }
        double temp = sum / matrix.GetLength(0);//находим среднее арифметическое в каждом столбце,путем деления суммы элементов в столбце на их количество(количество строк)
        double result = Math.Round(temp, 1, MidpointRounding.ToZero);//округляем результат до одного знака после запятой
        array[i] = result;
    }

    return array;// возвращаем наш одномерный массив
}

void PrintArray(double[] arr)//метод осуществляет печать(вывод) нашего двумерного массива (шаблонный)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("");
}

int[,] array2D = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2D);

double[] array1D = AverageColum(array2D);
Console.Write("Среднее арифметическое в каждом столбце: ");
PrintArray(array1D);