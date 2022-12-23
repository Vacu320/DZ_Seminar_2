// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//1. Ввод числа

int NumberFromUser()
{
    Console.WriteLine("Введите число от 100 до 999: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}
//2. Проверка числа на валидность
bool NumberValide(int number)
{

  return number >= 100 && number <= 999;

}
//3. Достать 2-ю цифру
int Number_2(int n)
{
    int a = n / 100;
    int b = (n / 10) % 10;
    int c = n % 10;

return b;
}
//4. Распечатать результат
string NewText(int input, int output)
{
    return input + " вторая цифра из данного числа--> " + output;
}

void Z10()
{
    int n = NumberFromUser();

    if (NumberValide(n))
    {
        int result = Number_2(n);
        System.Console.WriteLine(NewText(n, result));
    }
    else
    {
        System.Console.WriteLine("число кривое");
    }
}

Z10();