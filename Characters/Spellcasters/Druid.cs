using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private LightLeatherVest bodyArmor;
        private Staff weapon;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public override int ManaPoints
        {
            get
            {
                return base.ManaPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    base.ManaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Mana points for {base.Name} is out of range, it should be between 0 and 10.");
                }
            }
        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"HelathPoints for {base.Name} is out of range, it should be at least 0.");
                }
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

        public Staff Weapon
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

        public Druid()
            : this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {

        }

        public Druid(string name, int level)
            : this(name, level, Consts.Druid.HEALTH_POINTS)
        {

        }

        public Druid(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = Faction.Spellcasters;
            this.ManaPoints = Consts.Druid.MANA_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public int Moonfire()
        {
            throw new NotImplementedException();
        }

        public int Starburst()
        {
            throw new NotImplementedException();
        }

        public int OneWithTheNature()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}
