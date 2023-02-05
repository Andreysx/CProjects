// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void PrintArrayDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("||");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("||");
    }

}

double[,] SetAnArrayRndDouble(int rows, int columns, int min, int max)//метод задает массив размером m*n заполненный случайными вещественными числами
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double result = rnd.NextDouble() * (max - min) + min;
            array[i, j] = Math.Round(result, 1, MidpointRounding.ToZero);//округление и стратегия округления
        }

    }
    return array;// возвращаем массив заполненный случайными вещественными числами
}

PrintArrayDouble(
    SetAnArrayRndDouble(4, 4, -10, 10)
    );//вы это нам вроде еще не показывали, увидел в лекции, обычный вариант ниже
      // double[,] array = SetAnArrayRndDouble(4, 4, -10, 10);
      // PrintArrayDouble(array);