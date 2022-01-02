using System;
namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor is out of range, it should be at least 0");
                }
            }
        }
        public Armor(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
