//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
//Первые два элемента последовательности задаются пользователем

Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число a : ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число b : ");
int b = int.Parse(Console.ReadLine() ?? "0");

int PrintNumber(int a, int b, int num)
{
    if (num == 1) return a;
    if (num == 2) return b;
    return PrintNumber(a, b, num - 1) + PrintNumber(a, b, num - 2);
}
for (int i = 1; i <= N; i++)
{
    Console.Write(PrintNumber(a, b, i) + " ");
}
