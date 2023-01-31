// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других 

Console.WriteLine("Введите три стороны треугольника. ");
Console.Write("Введите сторону А");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону B");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону C");
int sideC = Convert.ToInt32(Console.ReadLine());


bool res = TriangleCheck(sideA,sideB,sideC);
Console.WriteLine(res ? "Да" : "Нет");

bool TriangleCheck(int a, int b , int c)
{
if (a <(b+c) && b < (a+c) && c<(b+c)) return true;
else return false;
}

// bool TriangleCheck(int a, int b , int c)
// {
// return a <(b+c) && b < (a+c) && c<(b+c);
// 
// }


// bool TriangleCheck(int a, int b, int c)
// {
//     if (a < (b + c) && b < (a + c) && c < (a + b)) return true;
//     else return false;

// }

// Console.WriteLine("Введите три стороны треугольника.");РЕШЕНИЕ ЭТОЙ ЗАДАЧИ С ВЫПОЛНЕНИЕМ УСЛОВИЙ ПРОВЕРОК
// Console.Write("Введите сторону a: ");
// int a;
// if (int.TryParse(Console.ReadLine(), out a))
// {
//     Console.Write("Введите сторону b: ");
//     int b;
//     if (int.TryParse(Console.ReadLine(), out b))
//     {
//         Console.Write("Введите сторону c: ");
//         int c;
//         if (int.TryParse(Console.ReadLine(), out c))
//         {
//             bool res = TriangleCheck(a, b, c);
//             Console.WriteLine(res ? "Да" : "Нет");
//         }
//         else Console.WriteLine("Введено некорректное значение.");
//     }
//     else Console.WriteLine("Введено некорректное значение.");
// }
// else Console.WriteLine("Введено некорректное значение.");