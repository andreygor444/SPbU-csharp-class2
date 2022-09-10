using System.Text.RegularExpressions;

namespace Task3
{
    public class Task3
    {
/*
 * Перед выполнением заданий рекомендуется просмотреть туториал по регулярным выражениям:
 * https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expression-language-quick-reference
 */

/*
 * Задание 3.1. Проверить, содержит ли заданная строка только цифры?
 */
        internal static bool AllDigits(string s) => new Regex(@"^\d*$").IsMatch(s);

/*
 * Задание 3.2. Проверить, содержит ли заданная строка подстроку, состоящую
 * из букв abc в указанном порядке, но в произвольном регистре?
 */
        internal static bool ContainsABC(string s) => new Regex("[aA][bB][cC]", RegexOptions.None).IsMatch(s);

/*
 * Задание 3.3. Найти первое вхождение подстроки, состоящей только из цифр,
 * и вернуть её в качестве результата. Вернуть пустую строку, если вхождения нет.
 */
        internal static string FindDigitalSubstring(string s) => new Regex(@"\d+").Match(s).ToString();

/*
 * Задание 3.4. Заменить все вхождения подстрок строки S, состоящих только из цифр,
 * на заданную строку S1.
 */
        internal static string HideDigits(string s, string s1) => new Regex(@"\d+").Replace(s, s1);

            public static void Main(string[] args)
        {
            AllDigits("23425");
            ContainsABC("dfbvkhABCvjkndf");
            FindDigitalSubstring("dfvkj324jkfb");
            HideDigits("dfkldvb23434cvn jk5t43bhb", "dfvs");
        }
    }
}