﻿Console.WriteLine ("Введите первое число: ");
int numberA = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе число: ");
int numberB = Convert.ToInt32 (Console.ReadLine ());


if (numberA == numberB * numberB | numberB == numberA * numberA)
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}