using System;

// Написать консольную программу, которая выводит сообщение +
// Пусть пользователь вводит в программу номер операции, и в зависимости от номера программа 
// программа выводит ему название операции
// Если введенное число не соответствует никакой операции - вывести сообщение 
// о том что операция неопределена.

    Console.WriteLine("Введите номер операции: 1. Сложения; 2. Вычитания; 3. Умножения");

    int operation = Convert.ToInt32(Console.ReadLine());
    switch(operation)
    {
        case 1:
            Console.WriteLine("Сложение");
            break;
        case 2:
            Console.WriteLine("Вычитание");
            break; 
        case 3:
            Console.WriteLine("Умножение");
            break;  
        default:
            Console.WriteLine("Операция не определена");   
            break;  
    }
    Console.ReadKey();
