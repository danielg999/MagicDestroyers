using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        public Axe()
            : this(Consts.Axe.DAMAGE_POINTS)
        {

        }
        public Axe(int damagePoints)
            : base(damagePoints)
        {

        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
