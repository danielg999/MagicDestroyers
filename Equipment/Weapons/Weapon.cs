using System;
namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon : Equipment
    {
        private int damage;

        protected virtual int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage is out of range, it should be at least 0");
                }
            }
        }
        public Weapon(int damage)
            : base()
        {
            this.Damage = damage;
        }
    }
}
