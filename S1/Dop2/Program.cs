// Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.
Console.WriteLine ("Введите число a:");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число b:");
int b= Convert.ToInt32(Console.ReadLine());

if (a<b)
{
    Console.WriteLine("Число а поместится в числе b");
    Console.WriteLine(b/a);
    Console.WriteLine("раз");
}
else
{
    Console.WriteLine("Число а должно быть меньше числа b");
    
}
