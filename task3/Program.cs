﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1/2;

if(number1 == number2*2)
{
    Console.Write("Да");
}

else
{
    Console.Write("НЕТ");
}