// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] mass = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(mass);
Console.WriteLine("");
ReturnValueElement(mass, row, column);


void ReturnValueElement(int[,] inArray, int inRows, int inColums)
{
    if (inRows >= 0 && inColums >= 0)
    {
        if (inRows < inArray.GetLength(0) && inColums < inArray.GetLength(1))
        {
            Console.Write($"{inRows}, {inColums} -> {inArray[inRows, inColums]}");
        }
        else
            Console.Write($"[{inRows}, {inColums}] -> такого элемента в массиве нет");
    }
    else 
     Console.Write("Введено некорректное значение");
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];///  0,1,
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)//цикл проходит по строкам// чтобы пройтись по столбцам нужно поменять цикли и i и j
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}