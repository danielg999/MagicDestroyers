using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();
            bool gameOver = false;

            int currentMelee = 0;
            int currentSpellcaster = 0;
            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                //new Warrior(),
                //new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                //new Mage(),
                //new Mage()
                new Necromancer(),
                new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                    meleeTeam.Add(character as Melee);
                else if (character is Spellcaster)
                    spellTeam.Add(character as Spellcaster);
            }

            while (!gameOver)
            {
                currentMelee = rng.Next(0, meleeTeam.Count);
                currentSpellcaster = rng.Next(0, spellTeam.Count);

                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[0].Attack(), meleeTeam[currentMelee].Name);

                if (!spellTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellcaster]);
                    if(spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }
                    
                }
                // 3.1 Check if the character died and remove him from the team
                // 3.2 If dead, get another character from the team

                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(), spellTeam[0].Name);
                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);
                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spell team wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }

                // 4. Spellcaster attacks Melee
                // 4.1 Check if the character died and remove him from the team
                // 4.2 If dead, get another character from the team

                // 5. If no characters are alive from either of the teams gameOver = true


            }
        }

        // Wonder about fields od armor and weapon in classes mage, warrior etc.
    }
}
