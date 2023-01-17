// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да

Console.WriteLine("Введите два целых числа: a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите два целых числа: b");
int b = Convert.ToInt32(Console.ReadLine());
if (a / b == b)
{
    Console.WriteLine($"Первое число {a} является квадратом второго {b}");
}
else
{
    Console.WriteLine($"Первое число {a} не является квадратом второго {b}");
}
