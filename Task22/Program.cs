// Задача 26: Напишите программу, 
// которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
Console.WriteLine($"Количество цифр в числе {number} = {QuantityNumber(number)}");
else
    Console.WriteLine("Введены некорректные данные");


int QuantityNumber(int num)
{

    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return (count);
}