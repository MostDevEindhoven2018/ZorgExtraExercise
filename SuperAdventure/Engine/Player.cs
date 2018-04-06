using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        private int _gold;
        private int _experience;
        private int _level;
        public int Gold { get { return _gold; } set { _gold = value; GoldChanged?.Invoke(_gold); } }
        public int Experience { get { return _experience; } set { _experience = value; ExperienceChanged?.Invoke(_experience); } }
        public int Level { get { return _level; } set { _level = value; LevelChanged?.Invoke(_level); } }
        public Inventory Inventory { get; set; }
        public BindingList<PlayerQuest> Quests { get; set; }

        public event Action<int> GoldChanged;
        public event Action<int> ExperienceChanged;
        public event Action<int> LevelChanged;

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) :
            base(currentHitPoints, maximumHitPoints)
        {
            this.Gold = gold;
            this.Experience = experiencePoints;
            this.Level = level;
            this.Inventory = new Inventory();
            this.Quests = new BindingList<PlayerQuest>();
        }
    }
}
