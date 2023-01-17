// Задача 9: Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2

int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99-> {number}");

int firstDigit = number / 10; //7
int secondDigit = number %10;//8

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа-> {secondDigit}");
// int result  = firstDigit > secondDigir ? firstDigit: secondDigit; тернарный оператор тоже решение задачи
//Console.WriteLine($"Наибольшая цифра числа -> {result}");
