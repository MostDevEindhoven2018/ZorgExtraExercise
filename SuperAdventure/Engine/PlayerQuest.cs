﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest details { get; set; }
        public bool isComplete { get; set; }

        public PlayerQuest(Quest details)
        {
            this.details = details;
            this.isComplete = false;
        }
    }
}
