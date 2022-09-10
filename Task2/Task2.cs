using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            StringBuilder sb1 = new StringBuilder("*", n);
            for (int i = 1; i < n; ++i) sb1.Append('*');
            string s1 = sb1.ToString();
            StringBuilder sb = new StringBuilder(s, s.Length * (n + 1) - n);
            for (int i = s.Length - 1; i >= 1; --i)
            {
                sb.Insert(i, s1);
            }

            return sb.ToString();
        }

/*
 * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
 * Например, для N=4 должна получиться следующая строка:

1  1
2  4
3  9
4 16

 * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
 * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
 * пробел. В решении можно использовать функции Pad*.
 */
        static int IntLength(int n)
        {
            int cnt = 0;
            while (n > 0)
            {
                n /= 10;
                ++cnt;
            }

            return cnt;
        }
        internal static string TabulateSquares(int n)
        {
            int n1 = IntLength(n);
            int n2 = IntLength(n*n);
            StringBuilder sb = new StringBuilder((n1 + n2 + 1) * n);
            for (int i = 1; i <= n; ++i)
            {
                sb.Append(i.ToString().PadRight(n1));
                sb.Append(' ');
                sb.Append((i * i).ToString().PadLeft(n2));
                sb.Append('\n');
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));
            Console.WriteLine(TabulateSquares(4));
        }
    }
}