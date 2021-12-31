using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Warrior warrior = new Warrior();
            Console.WriteLine(warrior.Name);
            Console.WriteLine(warrior.Faction);


            Mage mage = new Mage();
            Console.WriteLine(mage.ManaPoints);
        }
    }
}
