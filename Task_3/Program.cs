﻿Console.WriteLine("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
if(num%2==0){
  Console.WriteLine($"Число {num} является чётным.");
}
else{
  Console.WriteLine($"Число {num} является нечётным.");
}