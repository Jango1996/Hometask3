// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число и мы проверим является ли оно полиндропом.");
int number = Convert.ToInt32(Console.ReadLine());

while ( number < 9999 || number > 100000)
{
    Console.WriteLine("Введите пятизначное число");
    return;
}
int digit1 = number / 10000;
int digit2 = (number / 1000) % 10;
int digit4 = (number / 10) % 10;
int digit5 = number % 10;

if (digit1 + digit2 == digit4 + digit5)
{
   Console.WriteLine($"Введённое число палиндром {number}"); 
}
else
{
    Console.WriteLine($"Введённое число не палиндром {number}");
}













