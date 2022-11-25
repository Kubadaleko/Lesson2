// 18. По двум заданным числам проверять является ли одно квадратом другого.


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    System.Console.WriteLine($"{b} является квадром числа {a}");
}
else
{
    System.Console.WriteLine($"{b} не является квадром числа {a}");
}
