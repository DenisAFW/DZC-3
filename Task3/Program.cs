void FindSqrt(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.Write(i * i * i + " ");
        i++;
    }
}
Console.WriteLine("Введите число.");
int N = Convert.ToInt32(Console.ReadLine());
FindSqrt(N);