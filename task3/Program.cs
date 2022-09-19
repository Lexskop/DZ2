/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
int error = 0;
int userChoice = 1;
while (error == 1 || userChoice == 1)
{
    error = 0;
Console.WriteLine("Введите цифру дня недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber == 1 || userNumber == 2 || userNumber == 3 || userNumber == 4 || userNumber == 5)
{
    Console.WriteLine("Этот день не является выходным");
    Console.WriteLine("Вы хотите продолжить работу с программой? Да - 1, Нет - 0");
    userChoice = Convert.ToInt32(Console.ReadLine());
}
else if (userNumber == 6 || userNumber == 7)
{
    Console.WriteLine("Этот день является выходным");
    Console.WriteLine("Вы хотите продолжить работу с программой? Да - 1, Нет - 0");
    userChoice = Convert.ToInt32(Console.ReadLine());
    }
else
{
    Console.WriteLine("Вы ввели неккоректное число. Введите верное число");
    error = 1;
}
}