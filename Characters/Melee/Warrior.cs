using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Malee
    {
        private Chainlink bodyArmor;
        private Axe weapon;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 130;
        private const int DEFAULT_ABILITY_POINTS = 8;

        private const string DEFAULT_NAME = "Warrior X";
        private const Faction DEFAULT_FACTION = Faction.Malee;

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

        public Chainlink BodyArmor
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

        public Axe Weapon
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

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Warrior(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
