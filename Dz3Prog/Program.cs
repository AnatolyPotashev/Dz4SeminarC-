/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// for (int i = 1; i <= 8; i++)
// {
//     Console.WriteLine($"Введите {i} число:");
//     int num = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(num);
// Пытался через цикл сделать, пробовал num сделать массивом, но ошибки выдаёт

Console.WriteLine("Enter 1 number:");
int numbe1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2 number:");
int numbe2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 3 number:");
int numbe3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 4 number:");
int numbe4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 5 number:");
int numbe5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 6 number:");
int numbe6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 7 number:");
int numbe7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 8 number:");
int numbe8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{numbe1}, {numbe2}, {numbe3}, {numbe4}, {numbe5}, {numbe6}, {numbe7}, {numbe8}");
// Решил оставить так. Не понимаю как в цикле сделать переменную, которая будет принимать и запоминать несколько значений