// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Enter number:");
int num = int.Parse(Console.ReadLine());

int MultNumber(int num1)
{

int mult = 1;
while (num1 > 0)
{
    mult = num1 * mult;
    num1--;
}


return mult;
}
Console.WriteLine(MultNumber(num));