Console.WriteLine("Введите число-палиндром");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

int Palindrom(int a)
{
    while(a % 10 > 1)
    {
        b = (b * 10) + (a % 10);
        a = a / 10;   
    }
    b = (b*10) + a;
    return a;
}
Palindrom(a);

Console.WriteLine(b + " ");

if(a == b)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}
