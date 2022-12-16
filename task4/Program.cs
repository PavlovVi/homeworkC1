/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("введите число 1");
string input0 = Console.ReadLine() ?? "";
Console.WriteLine("введите число 2");
string input1 = Console.ReadLine() ?? "";
Console.WriteLine("введите число 3");
string input2 = Console.ReadLine() ?? "";


int a = Convert.ToInt32(input0);
int b = Convert.ToInt32(input1);
int c = Convert.ToInt32(input2);
int max = 0;

if((a >= b) && (a >= c))
max = a;
else if((b >= a) && (b >= c))
max = b;
else if((c >= a) && (c >= b))
max = c;

Console.WriteLine($"Наибольшее число {max}");