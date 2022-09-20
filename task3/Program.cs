/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Приветствую! Эта программа покажет, является ли введенный вами день недели - выходным!");
int error = 0;
string userChoice = "y";
while (error == 1 || userChoice.ToLower() == "y")
{
    error = 0;
    Console.WriteLine("Введите цифру дня недели: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber == 1 || userNumber == 2 || userNumber == 3 || userNumber == 4 || userNumber == 5)
        {
            if (userNumber == 1)
            {
                Console.Write("Вы выбрали Понедельник");
            }
                else if (userNumber == 2)
                {
                    Console.Write("Вы выбрали Вторник");
                }
                    else if (userNumber == 3)
                    {
                        Console.Write("Вы выбрали Среду");
                    }
                        else if (userNumber == 4)
                        {
                            Console.Write("Вы выбрали Четверг");
                        }
                            else if (userNumber == 5)
                            {
                                Console.Write("Вы выбрали Пятницу");
                            }
            Console.WriteLine(" -> Этот день не является выходным");
            
            Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
            userChoice = Console.ReadLine();
                while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
                {
                    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
                    userChoice = Console.ReadLine();
                }
        }
    else if (userNumber == 6 || userNumber == 7)
            {
                if (userNumber == 6)
                {
                    Console.Write("Вы выбрали Субботу");
                }
                else if (userNumber == 7)
                    {
                        Console.Write("Вы выбрали Воскресенье");
                    }
                Console.WriteLine(" -> Этот день является выходным");
                Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
                userChoice = Console.ReadLine();
                while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
                {
                    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
                    userChoice = Console.ReadLine();
                }
            }
        else
            {
                Console.WriteLine("Вы ввели неккоректное число. Введите верное число");
                error = 1;
            }
}
Console.WriteLine("Bye!");