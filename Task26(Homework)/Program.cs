// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 

// int result = LenthNumber(number);

// SummNumber(number, result);
 

int LenthNumber(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

void SummNumber(int num, int lenth)
{
    int summ = 0;
    for (int i = 1; i <= lenth; i++)
    {
        // summ += num % 10 ;
        summ = summ + num % 10;

        num = num / 10;
    }
    Console.WriteLine(summ);
}



Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lenth = LenthNumber(number);

SummNumber(number, lenth);

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);

// // Функция ввода
// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
// int index = 0;
// while (a > 0)
// {
// a /= 10;
// index++;
// }
// return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
// int sum = 0;
// for (int i = 1; i <= len; i++)
// {
// sum += n % 10;
// n /= 10;
// }
// Console.WriteLine(sum);
