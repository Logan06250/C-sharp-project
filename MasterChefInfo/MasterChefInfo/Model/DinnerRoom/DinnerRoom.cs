﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class DinnerRoom
    {
        List<Square> squares;
        MaitreHotel maitreHotel;
        int menu;

        public DinnerRoom()
        {
            squares.Add(new Square());
            squares.Add(new Square());
            maitreHotel = new MaitreHotel();
            menu = 40;
        }

        public void AddGroupClient(GroupClient groupClient)
        {

        }
    }
}
