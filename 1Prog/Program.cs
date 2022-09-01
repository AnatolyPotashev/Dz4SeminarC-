// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int GetSum(int numA)
{
int sum = 0;

while (numA > 0)
{
    sum = sum + numA;
    numA--;
}

    return (sum);
}

Console.WriteLine(GetSum(num));
