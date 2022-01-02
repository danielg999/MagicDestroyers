using System;
namespace MagicDestroyers
{
    public static class Tools
    {
        public static void ColorfullWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfullCW(string message, string type)
        {
            ConsoleColor color;

            //Console.WriteLine(type);
            switch (type)
            {
                case "MagicDestroyers.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkGreen;
                    break;
                case "MagicDestroyers.Characters.Melee.Knight":
                    color = ConsoleColor.Magenta;
                    break;
                case "MagicDestroyers.Characters.Melee.Assassin":
                    color = ConsoleColor.DarkRed;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Mage":
                    color = ConsoleColor.Blue;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Druid":
                    color = ConsoleColor.Green;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Necromancer":
                    color = ConsoleColor.Cyan;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
            //Console.WriteLine(type);
            //ColorfullWriteLine(message, color);
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
