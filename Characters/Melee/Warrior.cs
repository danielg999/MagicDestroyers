using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public override int AbilityPoints {
            get
            {
                return base.AbilityPoints;
            }
            set
            {
                if(value >= 0 && value <= 10)
                {
                    base.AbilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Ability points for {base.Name} is out of range, it should be between 0 and 10.");
                }
            }
        }

        public override int HealthPoints {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if(value >= 0)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"HelathPoints for {base.Name} is out of range, it should be at least 0.");
                }
            }
        }

        public Warrior()
            : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.HEALTH_POINTS)
        {

        }

        public Warrior(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = Faction.Malee;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 4;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}
