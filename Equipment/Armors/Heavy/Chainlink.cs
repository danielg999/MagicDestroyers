﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink : Heavy
    {
        private const int DEFAULT_ARMOR_POINTS = 30;

        public Chainlink()
            : this(DEFAULT_ARMOR_POINTS)
        {

        }
        public Chainlink(int armorPoints)
            :base(armorPoints)
        {
            
        }
    }
}
