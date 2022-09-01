// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

Console.WriteLine("Enter number:");
int num = int.Parse(Console.ReadLine());

int QuantityNumbers(int num1)
{
int fig = 0;

while (num1 > 0)
{
    fig++;
    num1 = num1 / 10;
}


return (fig);
}

Console.WriteLine(QuantityNumbers(num));