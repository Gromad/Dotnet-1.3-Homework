/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void CheckPalindorm(string number)
{
    int len = number.Length;
    if (len == 5)
    {
        if (number[0] == number[4] && number [1] == number[3])
        {
            Console.WriteLine($"{number} - Да. Число является палиндромом");
        }
        else
        {
            Console.WriteLine($"{number} - Нет. Это число не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Введено неправильное число");
    }
}

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

