// Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
//N = 4 -> 1, 1, 1, 1
//N = 2 -> 1, 1
Console.WriteLine ("Введите число:");
int N= Convert.ToInt32(Console.ReadLine());
int i=1;
Console.WriteLine("Решение:");
if (N>0)
{
    while ((N-i)>=0)
{
    Console.WriteLine(1);
    i ++;
}
}
else
{
    Console.WriteLine("N должно быть больше нуля");
}
