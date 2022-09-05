/*
Задача 64: Задайте значения M и N. Напишите программу, 
которая найдет сумму чисел от M до N.
M = 1; N = 5. -> 1, 2, 3, 4, 5
M = 4; N = 8. -> 4, 6, 7, 8
*/

System.Console.Clear();

System.Console.Clear();

int SumDigits(int n,int m)
{
    int sum = 0;
    if (m > n)
    {
        System.Console.WriteLine();
        return sum;   
    }
    sum += m;
    System.Console.Write(sum + " ");
    sum += SumDigits(n,m+1);
    return sum;
}

System.Console.WriteLine("Введите число начала ");
int m = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите последнее число");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"числа от {m} до {n}"); 
System.Console.WriteLine($"Сумма чисел => {SumDigits(n,m)}");