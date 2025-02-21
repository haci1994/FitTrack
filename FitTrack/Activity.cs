using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack
{
    public abstract class Activity
    {
        protected string ActivityName { get; set; }
        protected int Duration { get; set; }
        protected int ColoriesBurned { get; set; }

        public Activity(string name, int duration)
        {
            ActivityName = name;
            Duration = duration;
        }

        public abstract int CalculateCalories();

        public int GetBurnedColories()
        {
            return ColoriesBurned;
        }
    }

    public class Runnig : Activity
    {
        private int _perMinuteCalorie = 10;

        public Runnig(string name, int duration) : base(name, duration) {
            ActivityName = name;
            Duration = duration;
            
        }

        public override int CalculateCalories()
        {
            ColoriesBurned = Duration * _perMinuteCalorie;
            return ColoriesBurned;
        }

     
    }

    public class Cycling : Activity
    {
        private int _perMinuteCalorie = 8;

        public Cycling(string name, int duration) : base(name, duration)
        {
            ActivityName = name;
            Duration = duration;

        }

        public override int CalculateCalories()
        {
            ColoriesBurned = Duration * _perMinuteCalorie;
            return ColoriesBurned;
        }

        
    }
}
