// 22. Программа проверяет пятизначное число на палиндромом.


Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string a_str = a.ToString();
if (a_str.Length == 5 && a_str != string.Empty)
{
    if (a_str[0] == a_str[4] && a_str[1] == a_str[3])
    {
        System.Console.WriteLine($"пятизначное число {a}  является палиндромом.");
    }
    else System.Console.WriteLine($"пятизначное число {a}  НЕ является палиндром.");
}
else System.Console.WriteLine("Вы ввели не то что Вас просили");
