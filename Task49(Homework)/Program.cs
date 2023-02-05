// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


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
void ReturnMeaning(int[,] matrix, int line, int colum)//метод который возвращает значение элемента на указанных позициях или сообщает что такого элемента нет
{
    if (line >= 0 && colum >= 0)//проверка на корректность ввода данных(отрицательные значения)
    {
        if (line < matrix.GetLength(0) && colum < matrix.GetLength(1))//проверяем не выходят ли введенные данные за пределы массива
        {
            Console.Write($"[{line}, {colum}] -> ({matrix[line, colum]})");//если не выходят выводим значение
        }
        else
            Console.Write($"[{line}, {colum}] -> такого элемента нет");// если выходят сообщаем пользователю об отсутствии такогт элемента
    }
    else
        Console.Write("Введено неправильное значение");
}

Console.Write("Введите позицию элемента в ряду: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine("");
ReturnMeaning(array2D, row, column);