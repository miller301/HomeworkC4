Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int i = 0;
int mult = 1;
multipl(a, b);

void multipl(int n, int c)
{
    while (i < c)
{
 mult = mult*n;
 i++;
}
}
Console.WriteLine(mult);



