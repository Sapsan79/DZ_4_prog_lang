//Задача 25: Напишите цикл, который принимает
//на вход два числа (A и B) и возводит число A
//в натуральную степень B.

int A = ReadInt();
int B = ReadInt();
int result = 1;
for (int j = 0; j < B; j++)
{
    result *= A;
}
    Console.WriteLine(result);

int ReadInt()
{
    Console.WriteLine("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out int i))
    {
        return i;
    }
    Console.WriteLine("Вы ввели не число");
    return -1;

}