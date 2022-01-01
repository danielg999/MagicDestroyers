using System;
namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        public Hammer()
            : this(Consts.Blunt.DAMAGE_POINTS)
        {

        }
        public Hammer(int damagePoints)
            : base(damagePoints)
        {

        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
