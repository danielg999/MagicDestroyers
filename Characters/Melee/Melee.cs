using System;
namespace MagicDestroyers.Characters.Melee
{
    public abstract class Malee : Character
    {
        private int abilityPoints;

        public virtual int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Ability points for {base.Name} is out of range, it should be between 0 and 10.");
                }
            }
        }

        public Malee(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {

        }
    }
}
