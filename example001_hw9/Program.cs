// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Enter number N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(1, num));

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start + "," + PrintNumber(start + 1, end));
}
