using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Malee
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 10;

        private const string DEFAULT_NAME = "Assasin X";
        private const Faction DEFAULT_FACTION = Faction.Malee;

        private LightLeatherVest bodyArmor;
        private Sword weapon;

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
        public override Faction Faction
        {
            get
            {
                return base.Faction;
            }
            set
            {
                base.Faction = value;
            }
        }

        public LightLeatherVest BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Assassin(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
