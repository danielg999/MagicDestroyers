using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private static int DEFAULT_DAMAGE = 36;

        public Sword()
            : this(DEFAULT_DAMAGE)
        {

        }
        public Sword(int damage)
            : base(damage)
        {

        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
