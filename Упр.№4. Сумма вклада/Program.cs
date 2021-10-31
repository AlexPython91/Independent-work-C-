using System;

// Задача: Ввод суммы вклада. Расчет процентной стаки от суммы вклада пользователя

Console.Write("Введите сумму вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());

if(sum < 100) 
{
    sum += sum * 0.05;
}
else if(sum <= 200)
{
    sum += sum * 0.07;
}
else
{
    sum += sum * 0.1;
}
Console.WriteLine("Сумма вашего вклада с учетом процентов: " + sum);

