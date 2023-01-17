// Задача 9: Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2

int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99-> {number}");

//int firstDigit = number / 10; //7
//int secondDigit = number % 10;//8

// int result  = firstDigit > secondDigir ? firstDigit: secondDigit; тернарный оператор тоже решение задачи
//Console.WriteLine($"Наибольшая цифра числа -> {result}");

//int result = firstDigit > secondDigir ? firstDigit : secondDigit; //тернарный оператор тоже решение задачи
//Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int number)
{
    
    int firstDigit = number / 10; //7
    int secondDigit = number % 10;//8
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return 0;

}
