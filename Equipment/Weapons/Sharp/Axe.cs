using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private static int DEFAULT_DAMAGE = 37;

        public Axe()
            : this(DEFAULT_DAMAGE)
        {

        }
        public Axe(int damage)
            : base(damage)
        {

        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
