// Показать натуральные числа от M до N, N и M заданы
int m = ReadInt("Enter m number: ");
int n = ReadInt("Enter n number: ");
string NumbersRec(int m, int n)
{
 if (m <= n) return $"{m} " + NumbersRec(m + 1, n);
 else return String.Empty;
}

Console.WriteLine(NumbersRec(m, n)); 

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}