using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        private int _maxHitPoints;
        public int MaxHitPoints { get { return _maxHitPoints; } set { _maxHitPoints = value; HitPointsChanged?.Invoke(value); } }
        public int CurrentHitPoints { get; set; }

        public event Action<int> HitPointsChanged;

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaxHitPoints = maximumHitPoints;
        }
    }
}
