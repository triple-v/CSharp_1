﻿// Программа, которая на вход принимает целое число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число:");
int N=Convert.ToInt32(Console.ReadLine());
int count=1;
while(count<=N){
  if (count%2==0){
    Console.Write($"{count} ");
  }
  count++;
}