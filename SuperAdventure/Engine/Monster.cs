using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public MonsterID ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardXp { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(MonsterID id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, 
            int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaxDamage = maximumDamage;
            RewardXp = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
