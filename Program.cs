// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Result(int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result *= A;
//     }
//     return result;
// }

// int number1 = ReadInt("Введите число: ");
// int number2 = ReadInt("Введите степень числа: ");

// int sum = Result(number1, number2);

// System.Console.WriteLine($"{number1} в {number2} степени равно {sum}");




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Length(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// int Sum(int a, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += a % 10;
//         a /= 10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.Write($"Сумма цифр в числе {a} равна: {Sum(a, len)}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void FillArray(int[] array)
// {
//     Random rand = new Random();
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = rand.Next(0, 100);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         System.Console.Write(array[index] + "  ");
//         //System.Console.WriteLine("[" + string.Join(", ", array) + "]");
//     }
// }

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);