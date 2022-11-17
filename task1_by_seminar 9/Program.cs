// Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int M, int N)
{
    if (N < M) return;
    PrintNumber(M, N - 1);
    Console.Write(N + " ");
}
Console.Write("Введите число M : ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine() ?? "0");
PrintNumber(M, N);
