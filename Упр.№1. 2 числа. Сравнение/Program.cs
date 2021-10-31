using System;

// Задача. Пользователь вводит 2 числа, программа сравнивает и 
// выводит результат сравнения (равны, больше, меньше)

Console.WriteLine("Начнем!");  

 Console.Write("Введите первое число: ");
    string userAnswer = Console.ReadLine();
    int numberOne = Convert.ToInt32(userAnswer);
    int answerOne = numberOne;

Console.Write("Введите второе число: ");
    string userAnswerTwo = Console.ReadLine();
    int numberTwo = Convert.ToInt32(userAnswerTwo);
    int answerTwo = numberTwo;

    if(numberOne == numberTwo)
    {
        Console.WriteLine("Числа " + numberOne + " и " + numberTwo + " равны");
    }
    else if(numberOne > numberTwo)
    {
        Console.WriteLine("Число " + numberOne + " больше " + numberTwo);
    }
    else
    {
        Console.WriteLine("Число " + numberTwo + " больше " + numberOne);
    }
    Console.WriteLine("Упражнение закончено!");   

        
            
        
    
    