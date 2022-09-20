/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.WriteLine("Привествую! Данная программа предназначена для нахождения второй цифры из трёхзначного числа!");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
Console.WriteLine("Введите трёхзначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber < 0)
    {
        userNumber = userNumber * (-1);
    }
int result;
int lastDigit = 0;
int middleDigit = 0;
    if ((userNumber % 100) > (userNumber - 1) || (userNumber % 10000) > (userNumber % 1000))
        {
            Console.WriteLine($"Ваше число: {userNumber} -> У Вас не трёхзначное число");
        }
            else 
                if ((userNumber % 1000) == userNumber)
                {
                lastDigit = userNumber % 10;
                middleDigit = userNumber % 100;
                result = (middleDigit - lastDigit) / 10;
                Console.WriteLine($"Ваше число: {userNumber} -> Вторая цифра числа = {result}");
                }   
Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
        {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
        }
}
Console.WriteLine("Bye!");