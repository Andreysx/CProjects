//12. Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если число 1 не кратно числу 2, то
//программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

//Console.Write("Введите первое целое число A: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе целое число B: ");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a % b == 0)
//{
 //   Console.WriteLine($"{a} кратно {b}");
//}
//else
//{
 //   Console.WriteLine($"{a} не кратно {b}, остаток {a % b} ");
//}

//int remains = Remains(a,b);
//Console.WriteLine($"кратно");
//if remains = 0 ? {a}  кратно {b};
//int Remains(int a, int b)
//{
 //   return a % b;
//}


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
// Console.WriteLine($"{num1} кратно {num2}");
// }
// else
// {
// Console.WriteLine($"{num1} не кратно {num2} , остаток {num1 % num2}");
// }

int remains = Remains( num1,num2);
Console.WriteLine($"кратно ");

int Remains(int number1,int number2)
{
return number1 % number2;//ПРОГРАММА НЕ ДОКОНЦА НАПИСАНА!!!
}