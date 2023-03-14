/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int PriintText(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FunkchisAkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunkchisAkerman(m - 1, 1);
    else if (m > 0 && n > 0) return FunkchisAkerman(m - 1, FunkchisAkerman(m, n - 1));

    return FunkchisAkerman(m, n);
}

Console.WriteLine(FunkchisAkerman(PriintText("Введите число m"), PriintText("Введите число n")));
