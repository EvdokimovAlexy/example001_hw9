
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m > n)
        return 0;
    else
    {
        res = m + SumMN(m + 1, n);
        return res;
    }
}
Console.WriteLine(SumMN(m, n));


