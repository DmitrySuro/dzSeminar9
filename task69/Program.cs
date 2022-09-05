/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

System.Console.Clear();

int NumberOfPower(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    a *= NumberOfPower(a, b - 1);
    return a;
}

System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Число {a} в степени {b} => {NumberOfPower(a, b)}");