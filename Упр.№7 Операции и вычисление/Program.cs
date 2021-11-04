using System;

// Написать консольную программу, которая выводит сообщение +
// 1. Пусть пользователь кроме номера операйии вводит два числа
// 2. в зависимости от номера операции с введенными числами выпоняются действия. 
// 3. Результат вывести на консоль.

    Console.WriteLine("Введите первое число: ");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите номер операции: 1. Сложения; 2. Вычитания; 3. Умножения");
    
    int userAnswer = Convert.ToInt32(Console.ReadLine());  // конвертируем ответ в int
    int sum = 0;
    
    switch(userAnswer)
    {
        case 1:
            sum = numberOne + numberTwo;
            Console.WriteLine($"Результат = {sum}");  // вариант с интерпаляцией строк
            break;
        case 2:
            sum = numberOne - numberTwo;
            Console.WriteLine("Результат = " + sum);   // простое прибавление переменной
            break; 
        case 3:
            sum = numberOne * numberTwo;
            Console.WriteLine("Результат = " + sum);
            break;  
        default:
            Console.WriteLine("Операция не определена");   
            break;  
    }
    Console.ReadKey();