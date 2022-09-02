// Напишите цикл, 
// который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("Enter number A:");
double numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B:");
double numB = Convert.ToInt32(Console.ReadLine());

double result1 = 1;
int levelNumbers(double result1)
{
// int i = 1;
double result = 1;
for (int i = 1; i <= numB; i++)
{
    result = result*numA;

    return result;
}

return result;
}
Console.WriteLine(levelNumbers(result1));