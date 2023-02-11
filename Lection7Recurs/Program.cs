// РЕКУРСИЯ - ЭТО КОГЛА ФУНКЦИЯ ВЫЗЫВАЕТ САМА СЕБЯ
// 1ПЕРВЫЙ ПРИМЕР ИСПОЛЬЗОВАНИЯ РЕКУРСИИ
// Факториал = 5! = 5*4*3*2*1
//              5*4!
//               4*3!
//                3*2!
//   .....

// double Factorial(int n)      // ОПРЕДЕЛЯЕМ МЕТОД  КОТОРЫЙ ПРИНИМАЕТ ЧИСЛО ФАКТОРИАЛ КОТОРОГО НУЖНО ВЫЧИСЛИТЬ 
// {
//     // 1!=1
//     //0! = 1
// if(n == 1) return 1;
// else return n * Factorial(n-1);
// // Console.WriteLine(Factorial(3));//1*2*3 = 6
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// 222Второй пример импользования рекурсии
// Фибоначчи каждое следующее число задается через предыдущее
// 1 1 2 3 5 8 13 21..
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + false(n-2)


// int Fibonacci(int n) МЕТОД ВЫЧИСЛЕНИЯ ФИБОНАЧИИ С ТИПОМ ДАННЫХ INTEGER
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);

// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }
// double Fibonacci(int n) МЕТОД ВЫЧИСЛЕНИЯ ФИБОНАЧИИ С ТИПОМ ДАННЫХ DOUBLE
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);

// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }



