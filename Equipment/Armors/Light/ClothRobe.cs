using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe : Light
    {
        private const int DEFAULT_ARMOR_POINTS = 30;

        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        {

        }
        public ClothRobe(int armorPoints)
            : base(armorPoints)
        {

        }
    }
}
