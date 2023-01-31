// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



int[] FibonacciArray(int arrSize)
{
    int[] arr = new int[arrSize];
    arr[1] = 1;
    for (int i = 2; i < arrSize; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
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


Console.WriteLine("Введите желаемое кол-во цифр последовательности Фибонначи: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 1)
{
    int[] fibArray = FibonacciArray(size);
    PrintArray(fibArray);
}
else if (size == 1)

    Console.WriteLine("[0]");
else Console.WriteLine("Введено некорректное число");





// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());РЕШЕНИЕ БЕЗ СОЗДАНИЯ МАССИВА
// Fibonacci(number);



// void Fibonacci (int num)РЕШЕНИЕ  БЕЗ СОЗДАНИЯ МАССИВА
// {
//     int first = 0, second = 1;РЕШЕНИЕ  БЕЗ СОЗДАНИЯ МАССИВА
//     Console.Write($"Если N = {number} -> {first} {second} ");РЕШЕНИЕ БЕЗ СОЗДАНИЯ МАССИВА
//     for (int i = 2; i < number; i++)
//     {
//         int newNumber = first + second;
//         Console.Write($"{newNumber} ");
//         first = second;
//         second = newNumber;
//     }
// }
