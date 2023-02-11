// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
// //  }

//  Console.WriteLine(FactorialRec(10)); // 3628800

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8




Console.Write("Введите первое число : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = DigitNumber(number1, number2);
Console.Write(result);


int DigitNumber(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return num1 *  DigitNumber(num1, num2 - 1);


}