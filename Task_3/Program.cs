// Найти сумму элементов от M до N, N и M заданы

int m = ReadInt("Enter m number: ");
int n = ReadInt("Enter n number: ");

int SumRec(int m, int n)
{
    if (n == 0) return 0;
    return n + SumRec(m, n - 1);
}

Console.WriteLine(SumRec(m, n));

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


