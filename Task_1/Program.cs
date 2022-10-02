// Программа, которая на вход принимает два целых числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b){
    Console.WriteLine($"{a} = {b} (min и max отсутствуют)");
}
else{
    if(a>b){
    Console.WriteLine($"{a} > {b} (min = {b}; max = {a})");
    }
    else{
        Console.WriteLine($"{a} < {b} (min = {a}; max = {b})");
    }
}