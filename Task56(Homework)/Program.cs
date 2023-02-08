// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//МЕТОД ДЛЯ ОПРЕДЕЛЕНИЯ СУММ ПО СТРОКАМ - ОДНОМЕРНЫЙ МАССИВ
//МЕТОД НАХОЖДЕНИЯ НОМЕРА СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ ЭЛЕМЕНТОВ


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
        Console.Write($"Строка номер {i + 1}:   [");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}



int[] SummRows(int[,] matrix)//метод нахождения суммы в каждой строке
{
    int[] arr = new int[matrix.GetLength(1)];
    //инициализируем одномерный массив целых чисел и присваиваем ему возвращаемое количество столбцов в нашем двумерном массиве
    // int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)// цикл проходит по строкам массива
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
            arr[i] = sum;
        }
    }
    return arr;
}



void PrintArray(int[] arr)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.WriteLine($"Сумма строки {i + 1} = {arr[i]}; ");
        else Console.WriteLine($"Сумма строки {i + 1} = {arr[i]}.");
    }
    Console.Write("");
}


// void MinSumRow(int[] arr)
// {
//     int minRow = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (minRow < arr[i]) minRow = arr[i];
//         Console.WriteLine($"Номер строки с наимешьшей суммой элементов = {minRow}");
//     }

// }



Console.WriteLine("Задан прямоугольный двумерный массив:");
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int[] array = SummRows(array2D);
Console.WriteLine("Сумма элементов в каждой строке массива:");
PrintArray(array);
// MinSumRow(array);