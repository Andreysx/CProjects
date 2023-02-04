// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.Write("Введите размер массива: ");
int countNums = Convert.ToInt32(Console.ReadLine());
int[] array = QueryValue(countNums);
PrintArray(array);
int result = NumbersAboveZero(array);
Console.Write(" -> ");
Console.WriteLine(result);

int NumbersAboveZero(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}


int[] QueryValue(int size)// метод реализует пользовательский ввод и преобразует в массив
{
    int[] mass = new int[size];

    for (int i = 0; i < size; i++)
    {
        // int query;
        Console.Write($"Введите значение номер {i + 1}: ");//
        int query = Convert.ToInt32(Console.ReadLine());
        mass[i] = query;
    }
    return mass;
}



void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}












