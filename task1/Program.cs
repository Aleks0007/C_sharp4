/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int power = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPowerNum(num, power));

int GetPowerNum(int num1, int power1)
{
    int x = num1;
    while (power1 > 1)
    {
        x *= num1;
        power1--;
    }
    return x;
}