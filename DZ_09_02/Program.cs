/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int PriintText(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int NamberSumma(int n, int m)
{
    if (n == m)
        return m;
    else return n + NamberSumma(n + 1, m);
}

int namber = PriintText("Введите число n: ");
int namber2 = PriintText("Введите число m: ");
int summ = NamberSumma(namber, namber2);
System.Console.WriteLine(summ);



