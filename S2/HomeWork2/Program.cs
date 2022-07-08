/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);
if (nText.Length > 2){
  Console.WriteLine("Третья цифра: " + nText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите цифру, обозначающую день недели: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());
;
if (DayWeek==6 || DayWeek==7)
{
    Console.WriteLine("Это выходной день");
}
else if (DayWeek<6)
  {
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("В неделе всего 7 дней");
}
