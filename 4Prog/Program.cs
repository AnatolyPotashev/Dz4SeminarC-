// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами 
// в случайном порядке.


int[] array = new int[8];
foreach (int num in array)
{
    Random rnd = new Random();
    int rnd2 = rnd.Next(0, 2);
    Console.Write(rnd2 + ", ");
}