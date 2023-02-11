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

//int result = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор тоже решение задачи 9 сокращение конструкции if -then-else
//Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);// метож MaxDigit возвращает значение в переменную maxDigit (исходные данные=> numder)
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
int maxDigit1 = MaxDigit(51);// метож MaxDigit возвращает значение в переменную maxDigit (исходные данные=> numder) 
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");//Показали что метод при его вызове  будет рабоать в любой строчке кода

int MaxDigit(int num)// к примеру num=number или num = 51 или num = 89 и тд в зависимости от заданного значения
{

    int firstDigit = num / 10; //7
    int secondDigit = num % 10;//8
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    //if(firstDigit > secondDigit)
    //int result = firstDigit;
    //else
    //int result = secondDigit;
    // переменная = условие? выражение1:выражение2;
    return result;

}
int maxDigit2 = MaxDigit(89);// метож MaxDigit возвращает значение в переменную maxDigit (исходные данные=> numder)
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");//Показали что метод при его вызове  будет рабоать в любой строчке кода