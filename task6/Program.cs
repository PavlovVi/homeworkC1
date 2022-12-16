/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("введите число");
string input0 = Console.ReadLine() ?? "";
int a = Convert.ToInt32(input0);

                           
if (a % 2 == 0)
   {
    Console.WriteLine("да, чётное");    
   }
else
   {
    Console.WriteLine("нет, нечётное");
   }
  