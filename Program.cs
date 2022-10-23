/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int SecondDigit(int number)
{
    int dez = number % 100;
    int ed = dez / 10;
    return ed;
}


Console.Write("Input 3digits number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(num);
Console.WriteLine($"The second digit from {num} is {result}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int ThreeDig(int number)
{
    if(number < 100)
    {
        return -1;
    }
    else 
    {
        while(number > 999)
        {
            number = number / 10;
        }
    int result = number % 10;
    return result;
    }
}
    
Console.Write("Input any number ");
int num = Convert.ToInt32(Console.ReadLine());
int res = ThreeDig(num);
if(res == -1)
{
    Console.WriteLine("Three digit is not detected");
}
else
{
    Console.WriteLine($"{res}");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
bool DayWeek(int number)
{
    if(number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
    
}
Console.Write("Input the number of day in the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = DayWeek(num);
if(result == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/
