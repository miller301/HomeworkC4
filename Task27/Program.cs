
Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;

sum(n);

void sum(int a)
{
    while (a>0)
{
s = s + a%10;
a = a/10;
}
Console.WriteLine(s);
}

