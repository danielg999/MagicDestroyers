using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private static int DEFAULT_DAMAGE = 30;
        
        public Hammer()
            : this(DEFAULT_DAMAGE)
        {

        }
        public Hammer(int damage)
            : base(damage)
        {

        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
