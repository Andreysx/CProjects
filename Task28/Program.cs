// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)// i<arr.Lenth/size
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray (int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if(i < arr.Length -1) Console.Write($"{arr[i]}, ");  
//       else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] GetSumNegativePositiveElem(int[] arr)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];// сбособ возвращения массива одним методом ниже вывод его
        else sumPositive += arr[i];

    }
    return new int[] { sumNegative, sumPositive };

}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumNegativePositiveElem = GetSumNegativePositiveElem(array);//вывод после одного метода
Console.WriteLine();//вывод после одного метода
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativePositiveElem[0]}");//вывод после одного метода
Console.WriteLine($"Сумма положительных элементов = {sumNegativePositiveElem[1]}");//вывод после одного метода


int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)//способ возвращения двумя методами это первый для негатив
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)//способ возвращения двумя методами это второй для позитив
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}


int sumNegativeElem = GetSumNegativeElem(array);//вывод после двух методов
int sumPositiveElem = GetSumPositiveElem(array);//вывод после двух методов
Console.WriteLine();//вывод после двух методов
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");//вывод после двух методов
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");//вывод после двух методов
