// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
// //  }

//  Console.WriteLine(FactorialRec(10)); // 3628800
// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SummNumber(number);
Console.Write(result);



int SummNumber(int num)
{
    if (num == 0) return 0;
    return num % 10 + SummNumber(num / 10);//сначала выполняется рекурсия(рекурсивные вызовы) а потом вычисления

}