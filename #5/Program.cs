// Написать программу возведения числа А в целую стень B

int Exponentiation(int a, int b){
    if (b>0) return a * Exponentiation(a, b-1);
    // if (b<0) return 1 / a * Exponentiation(a, b+1);
    if(b==0) return 1;
    return 1;
}

int ReadInt(string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int a = ReadInt("Введите число A:");
int b = ReadInt("Введите число B:");
Console.WriteLine(Exponentiation(a, b));