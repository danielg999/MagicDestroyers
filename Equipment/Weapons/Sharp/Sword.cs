using System;
namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        public Sword()
            : this(Consts.Sword.DAMAGE_POINTS)
        {

        }
        public Sword(int damagePoints)
            : base(damagePoints)
        {

        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
