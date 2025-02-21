using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack
{
    public class FitTrackPro : FitnessTracker_base
    {
        public FitTrackPro(string name) : base(name)
        {
            DeviceName = name;
            _stepsLimit = 100000;
            Users = new string[5];
            BatteryLife = 48;
            _userIndex = 0;
        }

        
        public override void TrackSteps (int steps)
        {
            if (steps > 1 && steps < _stepsLimit)
            {
                _totalSteps += steps;
                Console.WriteLine($"You have tracked {steps} steps. Total is {_totalSteps}");
            }
            else { Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 100,000."); }

        }

        public virtual void AddUser(string userName)
        {
            if (_userIndex >= 5)
            {
                Console.WriteLine("Cannot add more users. The limit of 5 users has been reached.");
                return;
            }

            Users[_userIndex] = userName;
            Console.WriteLine($"User {userName} has been added successfully!");
            _userIndex++;
        }
    }

   
}
