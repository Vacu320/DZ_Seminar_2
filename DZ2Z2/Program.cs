// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

int n = int.Parse(Console.ReadLine()!);
int result = 0;

    if (n >= 100)
    {
        while (n > 999)
        {
            n = n / 10;
        }
        result = n % 10;
        System.Console.WriteLine($"третья цифра в заданном числе --> {result}");

    }
    else
    {
        System.Console.WriteLine("!третьей цифры нет!"); 
    }
            
