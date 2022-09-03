// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int Summaa(int summa)
{

int fig = 0;
int fig1 = 0;
int res = 0;
for (int i = num; i > 0; i--)
{
  fig = num % 10;
  fig1 = num / 10;
  res  = fig + fig1;

return res;   
}

if (num < 10)
{
    Console.WriteLine(fig);
}

return res;
}
Console.WriteLine(Summaa(num));

// Программа работает с двузначными числами. Я в семинаре посмотрю как исправить, нет даже мыслей по решению...
