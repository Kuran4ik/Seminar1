// Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
//N = 72334 -> 20:5:34 
Console.WriteLine ("Введите количество секунд:");
int N= Convert.ToInt32(Console.ReadLine());
int a; 
int b; 
int c;
a = N / 3600;
b = (N-a*3600) / 60;
c = N-a*3600-b*60;
Console.WriteLine("Время в формате часы:минуты:секунды:");
Console.WriteLine(a);
Console.WriteLine("часов");
Console.WriteLine(b);
Console.WriteLine("минут");
Console.WriteLine(c);Console.WriteLine("секунд");




