// Найти сумму элементов в промежутке от M до N, N и M заданы

int Sum(int M, int N)
{
    if (N == M) return N;
    return M + Sum(M + 1, N);
}
Console.Write("Введите число M : ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма элементов: {Sum(M, N)}");