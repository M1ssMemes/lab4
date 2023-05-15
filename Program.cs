Console.WriteLine("Введите строку для шифрования:");
const string alf = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
var str = string.Empty;
str = Console.ReadLine().ToLower();
var result = string.Empty;
const int d = 5;
var x1 = (-3 + Math.Sqrt(d)) / 2;
var x2 = (-3 - Math.Sqrt(d)) / 2;
var s1 = (((((x1 + 3) * x1 + 1) * x1 + 1) * x1 + 4) * x1 + 4) * x1 + 3;
var s2 = (((((x2 + 3) * x2 + 1) * x2 + 1) * x2 + 4) * x2 + 4) * x2 + 3;
var k = Math.Floor(s1);
for (var i = 0; i < str.Length; i++)
{
    if (alf.Contains(str[i]))
        result += alf[((alf.IndexOf(str[i]) - (int)k) % 33)];
}
Console.WriteLine("Полученная строка:");
Console.WriteLine(result);