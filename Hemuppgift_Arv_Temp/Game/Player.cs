﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        //användarens ID, 
        protected string UserId { get; set; }

        //konstruktor
        public Player(string userId)
        {
            UserId = userId;
        }



    }
}
