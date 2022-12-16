/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

Console.WriteLine("введите число 1");
string input0 = Console.ReadLine() ?? "";
Console.WriteLine("введите число 2");
string input1 = Console.ReadLine() ?? "";
int num0 = Convert.ToInt32(input0);
int num1 = Convert.ToInt32(input1);

if(num0 > num1)
{
    Console.WriteLine($"Число {num0} больше числа {num1}");
}
else if(num0 < num1)
{
    Console.WriteLine($"Число {num1} больше числа {num0}");
}
else if(num0 == num1)
{
    Console.WriteLine($"Вы ввели два равных друг другу числа {num0} и {num1}");
}