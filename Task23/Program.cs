// Задача 28: Напишите программу, 
// которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int factorialNumbers = FactorialNumbers(number);РЕШЕНИЕ
// Console.WriteLine($"Произведение чисел от 1 до {number} = {FactorialNumbers(number)}");РЕШЕНИЕ


// int FactorialNumbers(int num)РЕШЕНИЕ
// {
//     int fact = 1;
//     for (int i = 1; i <= num; i++)РЕШЕНИЕ
//     {
//         fact = fact * i;


//     }
//     return (fact);РЕШЕНИЕ

// }


int Factorial(int num)
{
    int productnum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // выражение проверяет на переполнение завершается с ошибкой
        {
            productnum = productnum * i;
        }

    }
    return productnum;
}

Console.Write("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
{
    if (number > 0)
        Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
    else
        Console.WriteLine("Введено некорректное значение. Введите натуральное число.");
}
else
    Console.WriteLine("Введено некорректное значение. Введите целое число");