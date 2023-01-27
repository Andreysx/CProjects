// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
// }
int[] array = FillArray(8);

PrintArray(array);
Console.Write(" -> ");
PrintArray2(array);



int[] FillArray(int arr)
{
    int[] arrayy = new int[arr];

    Random rnd = new Random();
    for (int i = 0; i < arr; i++)
    {
        arrayy[i] = rnd.Next(10, 100);
    }
    return arrayy;
}


void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ",");
        // Console.Write(string.Join(arr[i] + ","));
    }

}
void PrintArray2(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ",");
        // Console.Write(string.Join(arr[i] + ","));
    }
    Console.Write("]");
}
