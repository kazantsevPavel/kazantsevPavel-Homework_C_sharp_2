//  Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100.
//  При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
//  Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz.
//  Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
Console.WriteLine("Здравствуйте, сэр! Давайте немного побитбоксим?");
Console.WriteLine("Введите число от 1 до 100, пожалуйста");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1 || N > 100) Console.WriteLine("Сэр, давайте всё же ограничимся числами от 1 до 100!");
// int [] array = new int [N]
else
{
    for (int i = 1; i <= N; i++)
    {
        if (i % 15 == 0) Console.Write("FizzBuzz ");
        
        else if (i % 3 == 0) Console.Write("Fizz ");
        
        else if (i % 5 == 0) Console.Write("Buzz ");
         
        else Console.Write(i + " ");

    }
}
Console.WriteLine("!!!");
Console.WriteLine("Отлично побитбоксили, сэр!");