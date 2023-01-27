// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Введите первое целое число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{number1}, {number2} -> {DegreeNumber(number1,number2)}");

// double DegreeNumber(double num1, double num2)
// {
// double x = num1;
// double stepen = num2;
// double result = Math.Pow(x, stepen);
// return result;
// }

void DegreeNumber(int a, int b)
{
    if (b > 0)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }

        Console.WriteLine($"{a}, {b} -> {result}");

    }
    else
    Console.WriteLine("Введены некорректные данные");
}
DegreeNumber(number1, number2);