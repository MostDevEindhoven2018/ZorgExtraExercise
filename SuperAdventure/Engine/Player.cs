﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) :
            base(currentHitPoints, maximumHitPoints)
        {
            this.Gold = gold;
            this.Experience = experiencePoints;
            this.Level = level;
            this.Inventory = new List<InventoryItem>();
            this.Quests = new List<PlayerQuest>();
        }
    }
}