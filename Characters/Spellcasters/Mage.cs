using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public override int ManaPoints
        {
            get
            {
                return base.ManaPoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    base.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Ability points for {base.Name} is out of range, it should be between 0 and 10.");
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

        public Mage()
            : this(Consts.Mage.NAME, Consts.Mage.LEVEL)
        {

        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTH_POINTS)
        {

        }

        public Mage(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = Faction.Spellcasters;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Fireball()
        {
            return base.Weapon.DamagePoints + 8;
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}
