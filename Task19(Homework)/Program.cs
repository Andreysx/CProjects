// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
Pallindrom(number);

void Pallindrom(int num)
{
    if (num >= 10000 && num <= 99999)
    {
        int num1 = num / 10000;
        int num5 = num % 10;
        if (num1 == num5)
        {
            num = num / 10;
            int num2 = (num / 100) % 10;
            int num4 = num % 10;
            if (num2 == num4)
                Console.WriteLine($"{number} -> Да");
        }
        else
            Console.WriteLine($"{number} -> Нет");
    }
    else
        Console.WriteLine($"Введено некорректное число");
}