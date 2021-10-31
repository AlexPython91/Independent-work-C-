using System;

// Задача: Ввод 1го числа, программа вычисляет (одно число "либо" другое)

Console.Write("Введите одно число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 5 | number == 10)
{
    Console.WriteLine("Число " + number + " либо равно 5, либо равно 10");
}
else
{
    Console.WriteLine("Неизвестное число");
}
