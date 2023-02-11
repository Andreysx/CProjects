// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] PrintSpiral2DArray(int height, int length)
// {
//     int[,] spiralArray = new int[height, length];

//     int i = 0;
//     int j = 0;

//     int xDirection = 1, yDirection = 0;
//     int direction = 0, sideLength = length;

//     for (int item = 0; item < spiralArray.Length; item++)
//     {
//         spiralArray[i, j] = item + 1;

//         --sideLength;
//         if (sideLength == 0)
//         {
//             // расчет длины стороны по которой приходимся в данный момент
//             // выбор по какой стороне сейчас идем
//             sideLength = length * (direction % 2) + height * ((direction + 1) % 2)
//                 // поправка по длине 
//                 - (direction/2 - 1) - 2;


//             int temp = xDirection;
//             xDirection = -yDirection;
//             yDirection = temp;
//             direction++;
//         }
//         i += yDirection;
//         j += xDirection;
//     }

//     return spiralArray;
// }

// int[,] myArray62 = PrintSpiral2DArray(10,10);
// PrintSpiral2DArray(myArray62);
