// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//метод задает двумерный массив целых чисел (наш шаблонный)
{
    int[,] matrix = new int[rows, columns];/// 0,1,
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
void PrintMatrix(int[,] matrix)//метод распечатывает двумерный массив целых чисел(наш шаблонный)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("||");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} |");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("||");
    }
}

void SortedRows(int[,] arr)//метод упорядочивает строки исходного массива по убыванию, ничего не возвращает.
{
    for (int i = 0; i < arr.GetLength(0); i++)//цикл проходит по строкам массива
    {
        for (int j = 0; j < arr.GetLength(1); j++)//цикл проходит по столбцам массива
        {
            for (int m = 0; m < arr.GetLength(1) - 1; m++)//цикл для сравнения  и обмена элементов строки
            {
                if (arr[i, m] < arr[i, m + 1])//условие для осуществления обмена, чтобы упорядочить массив по возрастанию достаточно менять < на >
                {
                    int temp = arr[i, m];//обмен элементами массива
                    arr[i, m] = arr[i, m + 1];//обмен элементами массива
                    arr[i, m + 1] = temp;//обмен элементами массива
                }
            }
        }
    }

}


// попробовать через инт

Console.WriteLine("Исходный массив");
int[,] array2D = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2D);
Console.WriteLine("Массив со строками по убыванию:");
SortedRows(array2D);
PrintMatrix(array2D);

