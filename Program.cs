// 64


void NaturalCoint(int a)
{
 Console.Write($"{a} ");
 if (a > 1 )
 NaturalCoint(a - 1);
}
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
NaturalCoint(b);