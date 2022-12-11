/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр = {GetSumNum(num)}");

int GetSumNum(int number)
{
    int sum = 0;
    int x = number;
    while (number > 0)
    {
        x = number % 10;
        sum += x;
        number /= 10;
    }
    return sum;
}