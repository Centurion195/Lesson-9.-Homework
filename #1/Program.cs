// Показать натуральные числа от M до N, N и M заданы

void NaturalNumbers(int M, int N){
    Console.Write($"{M}\t");
    if (M>N) NaturalNumbers(M-1, N);
    else if (N>M) NaturalNumbers(M+1, N);
}

int ReadInt(string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int M = ReadInt("Введите число М:");
int N = ReadInt("Введите число N:");
NaturalNumbers(M, N);