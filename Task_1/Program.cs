﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int getDeg(int a, int b)
{   
    int degree = 1;
    int sum = 1;
        for (int i = 0; i < b; i++)
        {
            degree = sum * a; 
            sum = degree;
        }
    return degree;
}

Console.WriteLine("Введите число А = ");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B = ");
int secNum = int.Parse(Console.ReadLine());

Console.WriteLine(getDeg(firstNum, secNum));

