﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(b > a) 
// {Console.WriteLine("MAX =  " + b);}

// else {Console.WriteLine("MAX = " + a);}



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;

// if(b > max) 
//  {max = b;}

// if(c > max)
//  {max = c;}

// Console.WriteLine("Наибольшее число = "+ max);



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a%2 == 0)
// {Console.WriteLine(a+" - это чётное число");}
// else {Console.WriteLine(a+" - это нечётное число");}



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число больше 1 ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
 while(a<=N)
 {
   Console.Write(" "+a+" ");
   a = a +2; 
 }
