﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Table
    {
        public int places { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }

        public int menus { get; set; }
        public int bread { get; set; }
        public int water { get; set; }

        public GroupClient groupClient { get; set; }
    }
}
