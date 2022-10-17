﻿// 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int x)
{
    if (x / 10000 == x % 10 && x / 1000 % 10 == x / 10 % 10)
    {
        Console.WriteLine("Это число палиндром");
    }
    else
    {
         Console.WriteLine("Это число не палиндром");
    }

}

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine()!);
Palindrome(x);
