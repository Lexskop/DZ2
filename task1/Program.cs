/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = 0;
int lastDigit = 0;
int middleDigit = 0;
lastDigit = userNumber % 10;
middleDigit = userNumber % 100;
result = (middleDigit - lastDigit) / 10;
Console.WriteLine($"Вторая цифра числа = {result}");