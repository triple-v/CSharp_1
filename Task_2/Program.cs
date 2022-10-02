Console.WriteLine("Введите первое целое число:");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число:");
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (a==b&&b==c&&c==a){
    Console.WriteLine($"Все числа равны.");
}
else{
    if(b>=max){
        max=b;
    }
    if (c>=max){
        max=c;
    }
    Console.WriteLine($"Максимальное число: {max}");
}