// Написать программу возведения числа А в целую стень B

int Exponentiation(int a, int b)
{
    if (b > 0) return a * Exponentiation(a, b - 1);
    if (b < 0) return a * Exponentiation(a, b + 1);
    if (b == 0) return 1;
    return 1;
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int a = ReadInt("Введите число A:");
int b = ReadInt("Введите число B:");
double result = Convert.ToDouble(Exponentiation(a, b));
if (b < 0) result = Math.Round(1 / result, 3);
Console.WriteLine($"Результат: {result}");