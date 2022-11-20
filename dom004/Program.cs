// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 22;
int b = 3;
int c = 9;
int max = a;

if (b > a)
{
   max = b;
}

 else
 {
    max = a;
 }

if (c > max)
{
    max = c;
}

Console.WriteLine ("max");
Console.WriteLine (max);



