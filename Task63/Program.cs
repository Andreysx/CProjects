// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumber(number);

void NaturalNumber(int num)
{
    if (num == 0) return;//условие выхода из РЕКУРСИИ       стэк - память 
    NaturalNumber(num - 1);//рекурсивный вызов
    Console.Write($"{num} ");
}

// void NaturalNumber(int num)
// {
//     if (num == 0) return;
//     //условие выхода из РЕКУРСИИ       стэк - память 
//     Console.Write($"{num} ");// хвостовая рекурсия, где она вызывается в конце
//     NaturalNumber(num - 1);
// }











// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0)
// {
//     int count = -num;
//     while (count <= num)
//     {
//         Console.WriteLine(count + " ");
//         count++;
//     }
// }
// else
// {
// //     Console.WriteLine("Число должно быть больше нуля");
// }