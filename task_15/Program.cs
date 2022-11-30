// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Здравствуйте, сэр! Подскажите, какой сегодня день недели?");
Console.WriteLine("Просто напишите цифру, сэр!");
Console.WriteLine("1.Monday");
Console.WriteLine("2.Tuesday");
Console.WriteLine("3.Wednesday");
Console.WriteLine("4.Thursday");
Console.WriteLine("5.Friday");
Console.WriteLine("6.Saturday");
Console.WriteLine("7.Sunday");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7) Console.WriteLine("Сэр, такого дня недели не существует");

else
{
    if (a > 5) Console.WriteLine("Сэр, сегодня выходной! Вот ваше шампанское, сэр!");
    else Console.WriteLine("Сэр, сегодня рабочий день! Вот ваш чай, сэр!");
}
Console.WriteLine("Хорошего дня, сэр!");