Console.WriteLine ("Введите первое число:");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int b= Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("Это большее число:");
    Console.WriteLine(a);
    Console.WriteLine("Это меньшее число:");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Это большее число:");
    Console.WriteLine(b);
    Console.WriteLine("Это меньшее число:");
    Console.WriteLine(a);
}