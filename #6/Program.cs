// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int[] SequenceSum(int a, int b, int n){
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 3; i <= array.Length; i++)
        array[i-1] = array[i-2] + array[i-3];
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}\t");
}

int ReadInt(string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int a = ReadInt("Введите число A:");
int b = ReadInt("Введите число B:");
int n = ReadInt("Сколько чисел вывести?");
PrintArray(SequenceSum(a, b, n));