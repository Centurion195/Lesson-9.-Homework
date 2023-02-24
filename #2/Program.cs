// Найти сумму элементов от M до N, N и M заданы

int SumNumbers(int M, int N){
    if (M>N) return M + SumNumbers(M-1, N);
    else if (N>M) return M + SumNumbers(M+1, N);
    return M;
}

int ReadInt(string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int M = ReadInt("Введите число М:");
int N = ReadInt("Введите число N:");
Console.WriteLine(SumNumbers(M, N));