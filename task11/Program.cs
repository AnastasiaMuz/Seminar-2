﻿// **Задача 11**. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int n = new Random().Next(100,1000);
Console.WriteLine ($"Наше случайное число {n}");
int digit1 = n / 100;
int digit2 = n % 10;

//Console.Write($"{digit1}{digit2}");

int res = digit1 * 10 + digit2;
Console.WriteLine (res);
