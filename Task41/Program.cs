// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

int[] CopyArray(int[] arr1)
{
    int[] copy = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        copy[i] = arr1[i];
    }
    return copy;
}

Console.WriteLine("Введите размер и диапазон значений массива.");
Console.Write("Размер массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное значение чисел в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение чисел в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] originalArray = CreateArray(arrSize, min, max);
PrintArray(originalArray);
Console.WriteLine("\r\n");
int[] replica = CopyArray(originalArray);
replica[0] = 777;
PrintArray(replica);