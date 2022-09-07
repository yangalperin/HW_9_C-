// Показать натуральные числа от N до 1, N задано
int a = ReadInt("Enter first number: ");
int n = ReadInt("Enter second number: ");
string NumbersRec(int a, int n)
{
 if (a <= n) return NumbersRec(a + 1, n) + $"{a} ";
 else return String.Empty;
}

Console.WriteLine(NumbersRec(a, n)); 

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}