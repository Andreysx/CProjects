// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(numberM, numberN);

void NaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);

    }
    else Console.WriteLine(num1);

}








// void IncorrectValue()
// {
//     Console.WriteLine("Введено некорректное значение");
//     Environment.Exit(0);
// }

// int UserInput()// метод проверки введеного параметра
// {
//     if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();//! логическое отрицание
//     return temp;
// }

// void NaturalNumbers(int numM, int numN)
// {
//     if (numM < numN)
//     {
//     Console.Write($"{numM} ");
//     NaturalNumbers(numM + 1, numN);
//     }
//     else if (numM > numN)
//     {
//     Console.Write($"{numM} ");
//     NaturalNumbers(numM - 1, numN);
//     }
//     else Console.WriteLine(numN);
// }


// Console.Write("Введите число M: ");
// int number1 = UserInput();
// Console.Write("Введите число N: ");
// int number2 = UserInput();
// NaturalNumbers(number1, number2);