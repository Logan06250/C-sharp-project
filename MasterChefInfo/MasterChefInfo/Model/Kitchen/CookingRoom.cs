﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class CookingRoom
    {
        public MasterChef masterChef { get; set; }
        public List<Ustensil> usedUstensil { get; set; }

        public CookingRoom()
        {
            masterChef = new MasterChef();
        }
    }
}
