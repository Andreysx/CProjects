// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] первая задача с массивом


int[] array = new int[8];//0,1,2,3,4,5,6,7
//array[0] = 123; пример обращения к массиву и положить в него значение

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}



void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);// у нас диапазон от 0 до 1(min,max), но в диапазоне последнее число не включаетмя в диапазон
    }
}

FillArray(array);
PrintArray(array);



// int[] arr = CreateArray(8);
// PrintArray(arr);


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];ТУТ МЫ СОЗДАЛИ МАССИВ ВНУТРИ МЕТОДА

//     Random rnd = new Random(); - ТАК ПРАВИЛЬНЕЕ СВЯЗАНО СО СКОРОСТЬЮ, ТАКТЫ ВРЕМЕНИ = 15МС И ЦИКЛ ВЫПОЛНЯЕТСЯ БЫСТРЕЕ 15МС
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;И ВЕРНУЛИ ЕГО
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
