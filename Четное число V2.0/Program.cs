using System;

// Четное ли число с запросом у пользователя

Console.Write("Введите число: ");
string userAnswer = Console.ReadLine();
int Answer = Convert.ToInt32(userAnswer);

int a = Answer;

if (a % 2 == 0)
{
    Console.WriteLine("Число четное!");
}
else
    Console.WriteLine("Число не четное");