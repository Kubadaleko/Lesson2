// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7)
{
    System.Console.WriteLine("в неделе всего 7 дней!!");
}
else if (a == 6 || a == 7)
{
    System.Console.WriteLine($"{a} выходной");
}
else
{
    System.Console.WriteLine($"{a} рабочий");
}

