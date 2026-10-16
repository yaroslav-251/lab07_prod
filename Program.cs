
// int a = 5;
// int b = 7;
// void DoubleValue(ref int number, ref int number1) {
//     int i = number;
//     number = number1;
//     number1 = i;
// }
// DoubleValue(ref a, ref b);
// Console.WriteLine(a);
// Console.WriteLine(b);
// шаг 3
// void TryDivice(int a, int b, out int result, out int des)
// {
//     result = a / b;
//     des = a % b;
// }
// int a = 7;
// int b = 9;
// TryDivice(a, b, out int d, out int t);
// Console.WriteLine($"частое {d}");
// Console.WriteLine($"остаток {t}");

//шаг 4

// void PrintStats(in CharacterStats stats) {
//     Console.WriteLine($"HP: {stats.Health}");
//     Console.WriteLine($"Урон: {stats.Damage}");
//     Console.WriteLine($"Броня: {stats.Armor}");
// }

// CharacterStats hero = new CharacterStats
// {
//     Health = 100,
//     Damage = 25,
//     Armor = 10
// };
// PrintStats(in hero);
// struct CharacterStats {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }
// шаг 5
using System.Drawing;
using System.Linq.Expressions;

void df (string a, string b, string color = "white", int weight = 180){
Console.WriteLine($"персонаж {a} из локации {b} имеет цвет {color} рост {weight}");
}

string a = "Ярослав";
string b = "дом";
string color = "зеленый";
int h = 200;
df(a, b);
df(a, b, color);
df(a, b, color, h);
df(a, b, h, color);
