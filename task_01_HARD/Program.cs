// Прогамма принимает на вход N чисел (число пользователя) и ищет среди них квадраты друг друга
Console.WriteLine("Сколько чисел будет в вашем массиве?");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int i = 0;
int j = 0;

while (i < N)
{
    Console.WriteLine("Введите число № " + (i + 1));
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

i=0;

while (j < N)
{
    while (i < N)
    {
        
        if (array[j] == array[i] * array[i])
        {
            Console.WriteLine($"{array[j]} это квадрат {array[i]}");
            i++;
        }
        else i++;
    }
    i = 0;
    j++;
}

Console.WriteLine ();