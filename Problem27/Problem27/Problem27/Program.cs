// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452-> 11
//82-> 10
//9012-> 12

int n = ReadInt();
int result = 0;
while (n / 10 > 0 || n % 10 > 0)
{
    result += n % 10;
    n /= 10;
}

Console.WriteLine(result);
int ReadInt()
{
    Console.WriteLine("Введите число: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        return i;
    }
    Console.WriteLine("Это не число");
    return -1;
}

