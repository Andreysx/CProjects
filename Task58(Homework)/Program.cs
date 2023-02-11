// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

void PrintMatrix(int[,] matrix)//метод распечатывает двумерный массив целых чисел(наш шаблонный)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");// 4- это форматирование для вывода массива
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}
int[,] MultiplicOfMatrixs(int[,] matrix, int[,] matrix2)
{
    int newMatrixRows = (matrix.GetLength(0) >= matrix2.GetLength(0)) ? matrix.GetLength(0) : matrix2.GetLength(0);
    //if (matrix.GetLength(0) >= matrix2.GetLength(0)) количество строк первой матрицы больше второй 
    //int newMatrixRows = matrix.GetLength(0)
    //else int newMatrixRows = matrix2.GetLength(0)
    int newMatrixColumns = (matrix.GetLength(1) >= matrix2.GetLength(1)) ? matrix.GetLength(1) : matrix2.GetLength(1);
    //if (matrix.GetLength(1) >= matrix2.GetLength(1)) количество столбцов первой матрицы больше второй 
    //int newMatrixRows = matrix.GetLength(1)
    //else int newMatrixRows = matrix2.GetLength(1)
    int[,] myltMatrix = new int[newMatrixRows, newMatrixColumns];

    if (matrix.GetLength(1) == matrix2.GetLength(0))//если количетсво столбцов первой матрицы(matrix) равно количетву строк второй матрицы(matrix2)
    {
        for (int i = 0; i < newMatrixRows; i++)
        {
            for (int j = 0; j < newMatrixColumns; j++)
            {
                for (int m = 0; m < matrix2.GetLength(0); m++)
                {
                    myltMatrix[i, j] += matrix[i, m] * matrix2[m, j];
                    //  myltMatrix[i, j] = myltMatrix[i, j] + matrix[i, m] * matrix2[m, j];
                }
            }
        }
        return myltMatrix;
    }
    else
    {
        Console.WriteLine("Число столбцов первой матрицы не равно числу сток второй матрицы,умножать нельзя");
        return myltMatrix;
    }
}

void PrintMyltiplicMatrix(int[,] matrix)//метод распечатывает двумерный массив целых чисел(наш шаблонный)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");// 4- это форматирование для вывода массива
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}

int[,] firstArray2D = CreateMatrixRndInt(2, 2, 0, 10);
int[,] secondArray2D = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("Например, даны 2 матрицы: ");
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstArray2D);
Console.WriteLine("");
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondArray2D);
Console.WriteLine("");
int[,] resultArray2D = MultiplicOfMatrixs(firstArray2D, secondArray2D);
Console.WriteLine("Результирующая матрица будет: ");
PrintMyltiplicMatrix(resultArray2D);


// void PrintMatrix(int[,] matrix, int[,] matrix2) пытался создать метод который распечатает сразу 2 матрицы, но что-то пошло не так
// {
// for (int i = 0; i < matrix.GetLength(0) && i < matrix2.GetLength(0); i++)
// {
//     Console.Write(" ");
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         if (j < matrix.GetLength(1) - 1 && j < matrix2.GetLength(1) - 1)
//         {
//             Console.Write($"{matrix[i, j],3} {matrix2[i, j],3}");
//         }
//         else Console.Write($" |{matrix[i, j],3} {matrix2[i, j],3}");
//     }
//     Console.WriteLine(" ");
// }
// }