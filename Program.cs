/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 456 -> 5
782 -> 8
918 -> 1

*/

/*
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;
   
    int result = (num - sot * 100 - ed)/10 ;
    return result;
}

Console.Write("Введите трехзначное число: ");
int numNew = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumber(numNew);

Console.WriteLine($"Новое число из {numNew} это {newNum}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

/*
int ThirdDigit(int num)
{
    int result = -1;
        if (num >= 100)
            {
                while (num > 999)
                {
                    num = num / 10;
                }
                result = num % 10;
            }
        return result; 
}

Console.Write("Введите  число: ");
int numNew = Convert.ToInt32(Console.ReadLine());
int newNum = ThirdDigit(numNew);

Console.WriteLine($"Новое число из {numNew} это {newNum}");
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TypeOfDay(day));

string TypeOfDay(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Yes");
        }
        else
        {
            Console.Write("No");
        }
    }
    else
    {
        Console.Write("Invalid number. Try again");
    }
    return " ";
}
*/