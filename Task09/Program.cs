// Задача 9: Напишите программу, 
//которая выводит случайное число
//из отрезка [10, 99] и 
//показывает наибольшую цифру числа.
//78 -> 8
//12-> 2

int number = new Random().Next(10, 100);// Random- выделение памяти, Next метод (параметры диапазона)
Console.WriteLine($"Случайное число из отрезка 10 - 99-> {number}");// Выводит случ число из данного диапазона

//int firstDigit = number / 10; //7 получаем переменную(делим без остатка)(целочисленное деление)
//int secondDigit = number % 10;//8 остаток от деления

//if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}"); Простое решение задачи 9 ветвлением(условный оператор)
//else Console.WriteLine($"Наибольшая  цифра числа -> {secondDigit}"); Простое решение задачи 9  ветвлением(условный оператор)

// int result  = firstDigit > secondDigit ? firstDigit: secondDigit; тернарный оператор
//( (?)если выполняется условие first возвращаем иначе(:) second ) тоже решение задачи 9
//Console.WriteLine($"Наибольшая цифра числа -> {result}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор тоже решение задачи 9
//Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);// метож MaxDigit возвращает значение в переменную maxDigit (исходные данные=> numder)
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int number)
{

    int firstDigit = number / 10; //7
    int secondDigit = number % 10;//8
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;

}
