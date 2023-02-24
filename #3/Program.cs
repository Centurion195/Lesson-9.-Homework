// Найти сумму цифр числа

int SumNumbers(int number)
{
    if (number == 0) return 0;
    return SumNumbers(number/10) + number % 10; //5+2+1
}

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(number));