// Написать программу вычисления функции Аккермана
int a = ReadInt("Enter a number: ");
int b = ReadInt("Enter b number: ");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(a,b));

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}