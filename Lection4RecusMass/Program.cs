//ДВУМЕРНЫЕ МАССИВЫ
// string[,] table = new string[2, 5];//определяем таблицу строк
                                   //по умолчанию для строк инициализауия происходит константой String.Empty
                                   // индексы для строк и столбцов меняются от нуля
                                   // table[0,0]  table[0,1]  table[0,2]  table[0,3] table[0,4]
                                   // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

//  table[1,2] = "слово";// как обратиться к элементу массива

//  for (int rows = 0; rows < 2; rows++)
//  {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
//  }

// // int[,] matrix = new int[3, 4];// определяем двумерный массив (инициализируем его и опр нужно количество памяти)

// void PrintArray(int[,] matr)//метод который будет выводить наш массив
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// for (int j = 0; j < 4; j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)//МЕТОД КОТОРЫЙ БУДЕТ ЗАПОЛНЯТЬ НАШУ МАТРИЦУ СЛУЧАЙНЫМИ ЧИСЛАМИ
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);//[1;10]
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);




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



