using System;
namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon
    {
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return this.damagePoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage is out of range, it should be at least 0");
                }
            }
        }
        public Weapon(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }
        public abstract void SpecialAbility();
    }
}
