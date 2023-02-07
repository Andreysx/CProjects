// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1)
                Console.Write($"{array[i, j],4} |");
            else Console.WriteLine($"{array[i, j],4}]");
        }
    }
}

bool MatrixRowsColumnsCheck(int[,] array2D)
{
    return array2D.GetLength(0) == array2D.GetLength(1);
}

void InvertedMatrix(int[,] array2D)
{
    int rowsCount = array2D.GetLength(0);
    int columnsCount = array2D.GetLength(1);
    for (int i = 0; i < rowsCount - 1; i++)
    {
        for (int j = i + 1; j < columnsCount; j++)
        {
            int temp = array2D[i, j];
            array2D[i, j] = array2D[j, i];
            array2D[j, i] = temp;
        }
    }
}

Console.Write("Введите кол-во строк в массиве: ");
int rowsSize = UserInput();
if (rowsSize <= 0) IncorrectValue();
Console.Write("Введите кол-во столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();
Console.Write("Введите левую границу диапазона чисел: ");
int minValue = UserInput();
Console.Write("Введите правую границу диапазона чисел: ");
int maxValue = UserInput();

int[,] matrix = MatrixCreate(rowsSize, columnsSize, minValue, maxValue);
    Console.WriteLine("Заданный массив:");
    PrintMatrix(matrix);
    
if (MatrixRowsColumnsCheck(matrix) == true)
{
    InvertedMatrix(matrix);
    Console.WriteLine("Новый массив:");
    PrintMatrix(matrix);
}
else Console.WriteLine("\r\nНевозможно заменить строки на столбцы.");
