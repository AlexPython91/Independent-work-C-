using System;

// Задача: Вычисление суммы вклада в процентах с учетом бонуса от банка в 15 едениц

// Мой вариант:

Console.Write("Введите сумму вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());
double bankBonus = 15;

if(sum < 100) 
{
    sum += sum * 0.05 + bankBonus;
}
else if(sum <= 200)
{
    sum += sum * 0.07 + bankBonus;
}
else
{
    sum += sum * 0.1 + bankBonus;
}
Console.WriteLine("Сумма вашего вклада с учетом процентов: " + sum);

// Вариант из решения:

/*Console.Write("Введите сумму вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());
double bankBonus = 15;

if(sum < 100)
{
    bankBonus = 0.05;
}
else if(sum <= 200)
{
    bankBonus = 0.07;
}
else
{
    bankBonus = 0.1;
}
sum += sum * bankBonus + 15;
Console.WriteLine("Сумма вашего вклада с учетом процентов: " + sum);*/