// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)




int[,,] CreateMatrix3D(int rows, int columns, int depth, int[] array)
{
    int[,,] matrix3d = new int[rows, columns, depth];
    if (rows * columns * depth < 99)
    {

        for (int i = 0; i < matrix3d.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3d.GetLength(1); j++)
            {
                for (int k = 0; k < matrix3d.GetLength(2); k++)
                {
                    matrix3d[i, j, k] = TwoDigitNumbers(array);
                }
            }

        }
    }
    else
    {
        Console.WriteLine("Массив очень большой ");
    }

    return matrix3d;
}

void PrintMatrix(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {

        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                Console.Write($" {matrix3d[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
    }

}

int TwoDigitNumbers(int[] arr)
{
    int numbers;
    do
    {
        numbers = new Random().Next(10, 100);
    }
    while (arr[numbers] != 0);
    arr[numbers] = 1;
    return numbers;
}

int[] array = new int[100];
int[,,] matrix3D = CreateMatrix3D(3,3,3,array);
PrintMatrix(matrix3D);
 //Решение посмотрел в интернете