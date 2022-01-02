using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                base.HealthPoints = value;
            }
        }

        public override int AbilityPoints
        {
            get
            {
                return base.AbilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    base.AbilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Ability points for {this.Name} is out of range, it should be between 0 and 10.");
                }
            }
        }

        public Assassin()
            : this(Consts.Assassin.NAME, Consts.Assassin.LEVEL)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, Consts.Assassin.HEALTH_POINTS)
        {

        }

        public Assassin(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = Faction.Malee;
            base.AbilityPoints = Consts.Assassin.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Raze()
        {
            return base.Weapon.DamagePoints + 8;
        }

        public int BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 4;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }
}
