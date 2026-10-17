
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
// using System.Drawing;
// using System.Linq.Expressions;

// void df (string a, string b, string color = "white", int weight = 180){
// Console.WriteLine($"персонаж {a} из локации {b} имеет цвет {color} рост {weight}");
// }

// string a = "Ярослав";
// string b = "дом";
// string color = "зеленый";
// int h = 200;
// df(a, b);
// df(a, b, color);
// df(a, b, color, h);
// итоговая задача

using System;

struct CharacterStats
{
    public int Health;
    public int Damage;
    public int Armor;
    public int Chakra;
}

class Program
{
    static void Main()
    {
        // персонаж Наруто
        CharacterStats naruto = new CharacterStats
        {
            Health = 100,
            Damage = 30,
            Armor = 10,
            Chakra = 50
        };

        Console.WriteLine("СИСТЕМА ПЕРСОНАЖА");
        Console.WriteLine();

        // 1. ref передаём здоровье по ссылке
        int health = naruto.Health;
        Console.WriteLine($"Здоровье до лечения: {health}");

        Heal(ref health, 20);

        Console.WriteLine($"Здоровье после лечения: {health}");
        Console.WriteLine();

        // 2. Обычный return
        int finalDamage = CalculateDamage(
            naruto.Damage, naruto.Armor);

        Console.WriteLine($"Итоговый урон: {finalDamage}");
        Console.WriteLine();

        // 3. out
        bool success = UseSkill(naruto.Chakra, 25, out int effect);

        if (success)
        {
            Console.WriteLine($"Умение применено! Эффект: {effect}");
        }
        else
        {
            Console.WriteLine($"Не удалось применить умение. Эффект: {effect}");
        }

        Console.WriteLine();

        // 4. in
        PrintStats(in naruto);

        Console.WriteLine();

        // 5. Необязательные параметры
        PrintCharacter("Наруто", 15);
        PrintCharacter("Саске", 16, "Ниндзя", true);

        PrintCharacter(
            name: "Сакура",
            level: 14,
            detailed: true,
            characterClass: "Медик"
        );
    }

    // ref
    static void Heal(ref int health, int amount)
    {
        health += amount;
    }

    // Обычные параметры
    static int CalculateDamage(int damage, int armor)
    {
        int result = damage - armor;

        if (result < 0)
        {
            result = 0;
        }

        return result;
    }

    // out
    static bool UseSkill(int chakra, int cost, out int effect)
    {
        if (chakra < cost)
        {
            effect = 0;
            return false;
        }

        effect = 50;
        return true;
    }

    // in
    static void PrintStats(in CharacterStats stats)
    {
        Console.WriteLine("Характеристики персонажа:");
        Console.WriteLine($"Здоровье: {stats.Health}");
        Console.WriteLine($"Урон: {stats.Damage}");
        Console.WriteLine($"Броня: {stats.Armor}");
        Console.WriteLine($"Чакра: {stats.Chakra}");
    }

    // Необязательные параметры 
    static void PrintCharacter(
        string name,
        int level,
        string characterClass = "Без класса",
        bool detailed = false)
    {
        if (detailed)
        {
            Console.WriteLine(
                $"Персонаж: {name}, уровень: {level}, " +
                $"класс: {characterClass}");
        }
        else
        {
            Console.WriteLine($"{name}, уровень {level}");
        }
    }
}


