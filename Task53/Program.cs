// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] AllNumbersArray(int[,] array2D)
{
    int arraySize = array2D.GetLength(0) * array2D.GetLength(1);
    int[] array = new int[arraySize];
    int count = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array[count] = array2D[i, j];
            count++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}.");
    }
}

void FrequencyDictionary(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num)
            count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count}");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count}");
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

int[] allNumberArray = AllNumbersArray(matrix);
Console.WriteLine("Все числа:");
Array.Sort(allNumberArray);
PrintArray(allNumberArray);

FrequencyDictionary(allNumberArray);