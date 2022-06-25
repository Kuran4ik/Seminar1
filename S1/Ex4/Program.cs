Console.WriteLine ("Введите первое число:");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число:");
int c= Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine("Максимальное число:");
    Console.WriteLine(a);
}
else if (b>a && b>c)
{
    Console.WriteLine("Максимальное число:");
    Console.WriteLine(b);
}
else if (c>a && c>b)
{
    Console.WriteLine("Максимальное число:");
    Console.WriteLine(c);
}