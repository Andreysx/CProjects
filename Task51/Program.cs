// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.




int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");// 4--- это форматирование для вывода массива
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}

void RowsSwap(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[firstRow, j];
        arr[firstRow, j] = arr[lastRow, j];
        arr[lastRow, j] = temp;

    }
}



int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
RowsSwap(array2D);
PrintMatrix(array2D);