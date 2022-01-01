using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private Chainlink bodyArmor;
        private Hammer weapon;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

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

        public Hammer Weapon
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

        public Knight()
            : this(Consts.Knight.NAME, Consts.Knight.LEVEL)
        {

        }

        public Knight(string name, int level)
            : this(name, level, Consts.Knight.HEALTH_POINTS)
        {

        }

        public Knight(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = Faction.Malee;
            base.AbilityPoints = Consts.Knight.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public int HolyBlow()
        {
            throw new NotImplementedException();
        }

        public int PurifySoul()
        {
            throw new NotImplementedException();
        }

        public int RighteousWings()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}
