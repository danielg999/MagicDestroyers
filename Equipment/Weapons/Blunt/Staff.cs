using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private static int DEFAULT_DAMAGE = 35;

        public Staff()
            : this(DEFAULT_DAMAGE)
        {

        }
        public Staff(int damage)
            : base(damage)
        {

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
