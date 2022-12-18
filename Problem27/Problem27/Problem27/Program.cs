// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452-> 11
//82-> 10
//9012-> 12

int n = ReadInt();
int result = 0;
GetSumm(ref n, ref result);

Console.WriteLine(result);
int ReadInt()
{
    Console.WriteLine("Enter a number");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        return i;
    }

    Console.WriteLine("It's not a number");

    return -1;
}
void GetSumm(ref int n, ref int result)
{
    while (n / 10 > 0)
    {
        result += n % 10;
        n /= 10;
    }
}