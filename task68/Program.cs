/*
Задача 68: Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/



System.Console.Clear();

int AkermanFun(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AkermanFun(m - 1, 1);
    else
        return AkermanFun(m - 1, AkermanFun(m, n - 1));
}

int m = 2;
int n = 3;
System.Console.WriteLine(AkermanFun(m, n));