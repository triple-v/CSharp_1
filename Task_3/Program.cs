// Программа, которая на вход принимает целое число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
if(num%2==0){
  Console.WriteLine($"Число {num} является чётным.");
}
else{
  Console.WriteLine($"Число {num} является нечётным.");
}