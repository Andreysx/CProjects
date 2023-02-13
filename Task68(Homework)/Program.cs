// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = NaturalNumber(numberM, numberN);
Console.WriteLine(result);



int NaturalNumber(int num1, int num2)
{
    if (num1 == num2+1) return 0;
    return num1 + NaturalNumber(num1 + 1, num2);
}



// int NaturalNumber(int num1, int num2)
// {
//     int summ = 0;
//     if (num1 == num2) return 0;
//     // Console.Write($"{num} ");
//     summ += NaturalNumber(num1, num2);
//     num1++;
//     return summ;
// }