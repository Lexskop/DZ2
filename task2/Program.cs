/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.WriteLine("Приветствую! Эта программа выведет третью цифру заданного числа или сообщит, что третьей цифры нет!");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
Console.WriteLine("Введите любое число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber < 0)
    {
        userNumber = userNumber * (-1);
    }
int index = 10;
int resolt = 0;
if ((userNumber % 100) > (userNumber - 1))
    {
        Console.WriteLine($"Ваше число: {userNumber} -> Третьей цифры в вашем числе - нет");
    }
    else
        {
        while (userNumber % index < userNumber)
            {
            index = index * 10;
            }
        resolt = ((userNumber % (index / 100)) - (userNumber % (index / 1000))) / (index / 1000);
        Console.WriteLine($"Ваше число: {userNumber} -> Третья цифра в вашем числе: {resolt}");
        }
    Console.WriteLine("Хотели бы вы проверить еще одно число? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
        {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
        }
}
Console.WriteLine("Bye!");