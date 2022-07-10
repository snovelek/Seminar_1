//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите последовательно 2 числа: ");
int number_1=0, number_2=0, sqr=0;
number_1 = Convert.ToInt32(Console.ReadLine());
number_2 = Convert.ToInt32(Console.ReadLine());
sqr=number_2*number_2;
if (sqr==number_1)
    Console.WriteLine("Первое число является квадратом второго");
    else
    Console.WriteLine("Первое число не является квадратом второго");



