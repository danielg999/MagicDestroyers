using System;
namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        public Staff()
            : this(Consts.Blunt.DAMAGE_POINTS)
        {

        }
        public Staff(int damagePoints)
            : base(damagePoints)
        {

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
