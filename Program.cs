// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Seminar 1
// // Задание. Ввести число и вывести его квадрат

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // int square = number * number;
// // number *= number;
// int square = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine("The square of the number: " + square);


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + b);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8