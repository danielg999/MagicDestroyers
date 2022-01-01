using System;
using MagicDestroyers.Enums;

namespace MagicDestroyers
{
    public static class Consts
    {
        // Characters
        public static class Warrior
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 130;
            public const int ABILITY_POINTS = 8;
            public const string NAME = "Warrior X";
        }

        public static class Knight
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 120;
            public const int ABILITY_POINTS = 9;
            public const string NAME = "Knight X";
        }

        public static class Assassin
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 100;
            public const int ABILITY_POINTS = 10;
            public const string NAME = "Assasin X";
        }

        public static class Mage
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 110;
            public const int MANA_POINTS = 30;
            public const string NAME = "Mage X";
        }

        public static class Druid
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 130;
            public const int MANA_POINTS = 18;
            public const string NAME = "Druid X";
        }

        public static class Necromancer
        {
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 120;
            public const int MANA_POINTS = 25;
            public const string NAME = "Necromancer X";
        }

        // Weapon
        public static class Blunt
        {
            public static int DAMAGE_POINTS = 31;
        }
        public static class Hammer
        {
            public static int DAMAGE_POINTS = 35;
        }
        public static class Axe
        {
            public static int DAMAGE_POINTS = 34;
        }
        public static class Sword
        {
            public static int DAMAGE_POINTS = 33;
        }

        // Armor
        public static class Chainlink
        {
            public const int ARMOR_POINTS = 33;
        }
        public static class LightLeatherVest
        {
            public const int ARMOR_POINTS = 30;
        }
        public static class ClothRobe
        {
            public const int ARMOR_POINTS = 28;
        }
    }
}
