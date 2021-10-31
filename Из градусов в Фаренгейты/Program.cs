using System;

// Перевдо из С в F
Console.Write("Сколько градусов цельсия Вы хотите преобразовать? ");

    string userAnswer = Console.ReadLine();
    int degrees = Convert.ToInt32(userAnswer);
    int c = degrees;

double f = degrees*1.8+32;
Console.WriteLine("Температура по Фаренгейту = " + f);
